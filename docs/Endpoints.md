# Endpoints

These are the endpoints that the API has and their usage

## `POST /tickets`

 - This endpoint creates a new unique ticket
 - The data sent by the caller are the fields that correspond to the creator in the [fields](Tickets.md#fields) section, namely title, description and priority and they belong in the request body
 - Priority is optional, if none is provided it will default to low
 - The responses from this endpoint are
	 - 201 Created: With the whole ticket as the body
	 - 400 Bad Request: When a rule is broken such as a title over 100 characters, missing description, the body has specifically what was the issue

## `GET /tickets/{id}`

 - This endpoint retrieves the data from a specified ticket
 - The data sent by the caller is only the id of the requested ticket, the id is part of the URL
 - The responses from this endpoint are 
	 - 200 OK: With the body containing all the fields from the specified ticket 
	 - 404 Not found: When the requested id doesn't match any existing ticket

## `GET /tickets`

 - This endpoint gives a list of all tickets
 - Optional filtering in the URL query: `status`(any from [status](Status.md)), `priority` (high, medium, low)
 - Filtering capitalization doesn't matter for ease of use
 - Results follow the rules from [ordering](Status.md#ordering)
 - The responses from this endpoint are
	 - 200 OK: the list of tickets as a summary (id, title, status, priority, assignee and created date) of each (empty if none match)
	 - 400 Bad Request: if the status or priority aren't a valid value

## `PATCH /tickets/{id}`

 - This endpoint is used to edit the status, priority and assignee of a ticket
 - The id of the ticket to be updated goes in the URL
 - Fields to be updated are included in the body and should only be valid ones in the case of status and priority
 - If a field for a ticket is not included it will stay unchanged
 - Status updating follows the rules from the [allowed status changes](Status.md#transitions)
 - Optional field of comment, if a status is being changed to awaiting or back to open from a different one a comment must be included, this is enforced through backend business logic, if a comment is added an author field (for the comment) is required too
 - Title and description cannot be changed
 - Responses for this endpoint are 
	 - 200 OK: the body of the updated ticket
	 - 400 Bad Request: if an invalid status or priority are entered, also if the update requires a comment that is missing or missing its author
	 - 404 Not found: When the requested id doesn't match any existing tickets
	 - 409 Conflict: when an update violates the rules or the ticket is closed


## `POST /tickets/{id}/comments`

 - Creates a new comment linked to the ticket whose id is sent
 - The id of the ticket to be commented goes in the URL
 - The comment itself goes in the body alongside the author (sent by the caller and not verified since v1 doesn't have user functionality, once user accounts exist it'll be taken from the logged in user) of the request
 - Closed tickets cannot be commented on
 - Responses from the endpoint are
	 - 201 Created: the id of the comment, the id of the ticket it belongs to, its text, author and the creation date
	 - 404 Not found: when the id doesn't match any existing ticket
	 - 400 Bad Request: when the text or author are missing or empty
	 - 409 Conflict: when trying to comment on a closed ticket

## `GET /tickets/{id}/comments`

 - Used to retrieve a list of the comments in a determined ticket
 - the id of the ticket whose comments are requested goes in the URL
 - If no comments exist in a requested id the response will be an empty list
 - those whose deleted property is set to true are excluded
 - Responses from the endpoint are
	 - 200 OK: the list of comments each with id, ticket id, text, author and created date
	 - 404 Not found: when a ticket matching the id requested doesn't exist

## `DELETE /tickets/{id}/comments/{commentId}`

 - Marks the comment as deleted, it becomes hidden but is not purged from the database
 - The responses from this endpoint are
	 - 204 No content: Deleted, also returned if the comment is already marked as deleted
	 - 404 Not found: The ticket or comment to be deleted doesn't exist
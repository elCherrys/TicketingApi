# Comments

Comments give updates on a [ticket](Tickets.md): new findings, additional data, something that wasn't included during creation, reasons for [status](Status.md) updates, and what solution was performed to close the ticket successfully.

## Fields

A comment has:

|Field|What it is|Type|Set by|
|---|---|---|---|
|ID|Unique identifier of the comment|Integer|System|
|Ticket ID|The ticket it belongs to|Integer|System|
|Text|The comment itself|Text|Author|
|Author|Who wrote it|Text|Author|
|Created date|When it was posted|Date and time|System|
|Deleted|Whether the comment is deleted or not|Boolean|System|

## Rules

- Comments can't exist by themselves, they must be linked to a ticket.
- The ID of a comment and the ticket ID it is bound to cannot be modified.
- Comments can be deleted and will no longer be visible, but they are not purged. They stay logged with all their data, with the possibility of restoration (pending implementation).
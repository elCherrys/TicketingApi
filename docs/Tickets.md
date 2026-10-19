# Tickets

Tickets are the main structure of the project.


## Fields

A ticket has:

| Field        | What it is                                                                                  | Type                | Allowed values                                                                                                     | Set by                                                    |
| ------------ | ------------------------------------------------------------------------------------------- | ------------------- | ------------------------------------------------------------------------------------------------------------------ | --------------------------------------------------------- |
| ID           | Unique identifier of each ticket                                                            | Integer             | Consecutive numbers                                                                                                | System                                                    |
| Title        | The name the ticket shows up with on the list of tickets, meant to be brief yet descriptive | Text                | Text up to 100 characters                                                                                          | Creator                                                   |
| Description  | Detailed information on the ticket                                                          | Text                | Text with no limit                                                                                                 | Creator                                                   |
| Status       | The current step of the ticket in the process of being solved                               | One from fixed list | [Open](Status.md#open), [Assigned](Status.md#assigned), [Awaiting](Status.md#awaiting), [Closed](Status.md#closed) | System, modified by the assignee                          |
| Priority     | How important the ticket is, depending on the impact of the issue being addressed           | One from fixed list | Low, Medium, High                                                                                                  | Creator, editable afterwards                              |
| Created date | The date and time the ticket was submitted                                                  | Date and time       | Set automatically                                                                                                  | System                                                    |
| Assignee     | The person in charge of the ticket                                                          | Text                | Text                                                                                                               | Self-assignment (admins are planned for a future release) |

Tickets are also updated through [comments](Comments.md) that are appended to each ticket.

## Rules

- IDs cannot be modified, manually defined or rolled back. They are unique and permanent to each created ticket.
- The created date is given automatically by the system and cannot be modified.
- The assignee is empty while the ticket's status is Open (see [assignee rules](Status.md#assignee)).
- The order in which tickets are worked on is described in [ordering](Status.md#ordering).
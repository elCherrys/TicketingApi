# Statuses

The status of a [ticket](Tickets.md) indicates what step in the process of being solved the ticket is currently in.

## Open

The ticket was created but hasn't been assigned to anyone and is not being worked on.

## Assigned

The ticket has been assigned to someone and is being worked on.

## Awaiting

Something is needed before the work can continue, for example missing data, contacting someone, or waiting for a date. Whatever the ticket is waiting on must be explained in a [comment](Comments.md).

## Closed

The status a ticket must be put in once it is completed and has no pending work left.

## Transitions

A status cannot be changed freely. These are the allowed changes:

| Status                | Can move to                                             |
| --------------------- | ------------------------------------------------------- |
| [Open](#open)         | [Assigned](#assigned)                                   |
| [Assigned](#assigned) | [Open](#open), [Awaiting](#awaiting), [Closed](#closed) |
| [Awaiting](#awaiting) | [Open](#open), [Assigned](#assigned), [Closed](#closed) |
| [Closed](#closed)     | -                                                       |

Reassigning a ticket to someone else doesn't change its status, so it isn't listed in the table.

## Rules

### Assignee

- A ticket can only be Assigned or Awaiting if it has an assignee.
- A ticket must be assigned to someone before it can be closed.
- Moving a ticket back to Open removes its assignee.
- A ticket can be reassigned directly to someone else without going through Open (by admins, pending implementation).

### Comments required

- A ticket can only be set to Awaiting if a comment explains what it's waiting on and why.
- Moving a ticket back to Open requires a comment explaining why.

### Closing

- Once a ticket is closed it cannot be reopened. A closed ticket can still be referenced by a new ticket or by a comment in a different ticket.

### Ordering

- Tickets are solved first come, first served, with priority taking precedence: higher-priority tickets are automatically moved up the queue.
- The exception is Awaiting tickets, which can be left behind lower-priority Open or Assigned tickets.
- Tickets are grouped by their priority.
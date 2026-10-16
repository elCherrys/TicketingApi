# Support Ticket System

A ticketing system meant to give better organization and sorting of tickets, so they can be solved properly.

## Contents

- [Tickets](Tickets.md)
- [Statuses](Status.md)
- [Comments](Comments.md)

## What v1 does

- Anyone can create tickets.
- Tickets can be read, their status changed, and comments added or deleted.
- Anyone can assign an Open ticket to themselves.
- The assignee can return their own ticket to Open (with a comment). Since returning it clears the assignee, someone else can then pick it up.

## What waits for admins (pending)

- Assigning a ticket to someone else.
- Reassigning directly, without going through Open.
- Taking a ticket away from someone.

## Later on

- Comment restoration
- User registration, role assignment and authentication
- Queue system
- Related tickets (a new ticket that references a closed one)
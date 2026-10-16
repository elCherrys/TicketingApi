# Ticketing API

A support ticketing system for organizing and sorting tickets so they can be solved properly. Tickets have priorities and statuses, move through a defined workflow, and collect comments explaining what happened along the way.

I'm building it as a portfolio project, starting from my experience handling customer tickets in a fintech call center.

> **Status: planning and early development.** The design is documented and the project skeleton is set up. The API and the web interface are not built yet.

## Planned features

- Create, view, edit and search tickets
- Priorities (low, medium, high) and a status workflow (Open, Assigned, Awaiting, Closed) with enforced rules for which changes are allowed
- Comments on tickets, including required explanations for key status changes
- Filters by status, priority and date, plus text search
- A change log for each ticket
- A simple web interface on top of the API

## Tech stack (planned)

- **Backend:** C# with ASP.NET Core Web API (.NET 10)
- **Database:** SQLite
- **Frontend:** plain HTML, CSS and JavaScript with Bootstrap
- **Hosting:** Oracle Cloud Always Free tier

## Documentation

The design lives in the [`docs`](docs/) folder:

- [Plan](docs/Plan.md): scope of version 1, what's pending, and what comes later
- [Tickets](docs/Tickets.md): the fields of a ticket and its rules
- [Statuses](docs/Status.md): what each status means and which changes between them are allowed
- [Comments](docs/Comments.md): the fields of a comment and its rules

## Roadmap

- [x] Project setup
- [x] Design documentation (tickets, statuses, comments)
- [ ] Endpoint definitions
- [ ] Interface sketches
- [ ] Ticket model
- [ ] Create, list and view tickets
- [ ] Edit tickets and add comments
- [ ] Filters and search
- [ ] Change log
- [ ] Deployment

## Running the project

Not available yet. Instructions will be added once there is something to run.
# .Net Project

### Name:
- Revista

### Description:
- An online movie database website using a movie api where a user can register for an account to login to rate, favourite, and review movies.

### Installation Instructions:
- Add/build to this as small changes are made/created, finalize and refine as you go.

### Function/Non-Functional Requirments:
- Functional
    - Home page with User Auth
        - Register/Login
    - Database
        - API 
    - Individual movie pages including info (Title, release date, genre etc.)
- Non-Functional
    - Social aspect that allows the user to follow other users and 
    - The ability to share to other social media
    - Login with Google, Facebook, Github etc.
    - 

### Must haves:
- Home page
    - Register
    - Login
- Movie selection page

### Nice to haves:
- Comment/Review text box with submit button
- A favourite button to add specific movies to your profile
- On individual movie pages, a link to the trailer of the movie
### Feature List:
- Ability to filter by category/genre via dropdown list
- Favourite button on each movie card
- A profile page that includes the favourites chosen by the user
- Navigation bar to switch to user home/profile/logout
- Register page
    - Confirm email
- Login page
    - Authentication (V2 or V3 or Two Factor)
- Logout button

<hr> 

### Prototype:
<a href="#">Prototype</a>

### ERD:
<img src="Revista_ERD.png" alt="Revista ERD"/>

<hr>

Note: This is a group assignment so please nominate ONE person to accept the assignment first and create your team so that others can join after and have access to the shared repository.

In your assigned teams, you will build a Web Application using a Microsoft SQL Server Database, Identity Authentication, a .NET Core backend, and either Server-Side rendered views (Razor Pages or MVC) OR Web API with Client-Side rendered views.

You can decide on the project within your group or consult with Phil to be provided with an idea for an application. As long as it is legal, appropriate for our academic setting, and agreed upon by your group by Monday Dec. 7th 11am PST.


## Design Requirements
All design docs hosted and maintained through out the project and embedded into the README.md file of your project repo. If you have a server and client repo, please use the project repo as your server and add a link to your client repo in the project repo's README. The README file should be nicely organized and presented as if a potential employer would see it. Design docs to include:

- App Description
    - Short non-technical "elevator pitch"
- Installation Instructions
    - Instruction for if you were to sign over the repo to an other development team, what steps would need to be taken to test the app locally. Ex. Names of Environment Variables/User Secrets, list of third party accounts that require membership, tools/scripts/commands that need to be run, etc.
- Requirements List
    - Functional and Non-Functional Requirements
- Feature List
    - Prioritized list of "must have" and "nice to have" features
- Prototypes
    - A prototype (or prototypes) that mock out the layout and flow of each of your app features. Start with "must have" and if your team gets to "nice to have" then you can add/update the prototype(s) on a case by case basis.
- ERD
    - An ERD that accurately represents your database structure. Update the entities, attributes and relationships as you go.

## Build Requirements
- An automated kanban templated Project Board must be maintained and connected to your repo(s).
- All tasks broken into small (finished in a day or so) GitHub issues and delegated/assigned to specific developers daily.
- All code is to be written on a "feature" branch
    - try to use a naming structure like pw18Login...pw are my dev initials, 18 is the issue number, and Login is what the issue is related to. Honestly, it should be whatever works best for your group.
    - every commit should be linked to a github issue by adding the #issueNumber in your commit message.
    - your goal should be to resolve your issue by making frequent and small commits and having a "code review" of a Pull-Request.
    - code can only be merged in to the main branch via a Pull-Request executed by another developer.
    - book a screen share meeting with another developer to quickly discuss each pull request. Document any key points with comments in the PR.
    - close the feature branch once the issue is complete
- Follow the steps demonstrated by Phil regarding regular pulls of main and merges into your featureBranch.
- Deploy all aspects of your application using Azure, AWS, Heroku, Netlify, etc or some combination.
    - I suggest you deploy your app immediately and make regular deployments throughout the build process.
- Other than appropriate comments for readability, do not allow any unecessary code onto your main branch.
- Modularize your code as much as possible and use appropriate service and repository classes and interfaces.

## Communication Requirements
Each group will need to establish a schedule for daily "stand-up" meetings that all group members must participate in. If a member is unable to attend a meeting, they must post their "update" to slack prior to the start of the meeting.

Format of a "stand-up" is that each person takes a minute or two to describe what they worked on the previous day, what they are currently working on and any blockers that they may be facing. Limit any back and forth discussion as most unless it affects the whole group, it can be taken "off-line" and dealt with while those not involved can get back to work.

I will leave the managment of issue creation and delegation to each group, but I find that a good practice when on tight timelines is to allow everyone to add issues to the board independantly but then add comments with other developers to quickly define and prioritize each item. If a developer needs to communicate details relating to a specific issue, please try to add these comments with user tagging to the Github issue itself.

If you are unable to live up to a deadline that has been assigned by the group, be sure to communicate this with the entire team prior to that deadline if possible. If this occurs more than once, please be sure to communicate this with your instructor (if you have not done so already), to discuss possible steps to help prevent further occurrences. It is important to set (and deliver on) regular and reasonable deadlines so that the team can manage the overall workload and progress of the project.

## Due Dates
- Group Agreement on Project Idea/Scope

     - 11:00am PST December 7, 2020

- Project Repo(s) on GitHub with project board, initial Features and Requirements list with at least 20 issues added and assigned within the kanban board, initial ERD embedded in the README, at least one feature branch created per member of the team.

    - 5:00pm PST December 7, 2020

- Inital Site(s) deployed with base level Authentication

    - 5:00pm PST December 8, 2020

- Final commits

    - 5:00pm PST December 17, 2020
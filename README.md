# Soccer Club
## Web application development assignment 
---
#### Part 1
* Create views for the following pages:
  * Home
  * Club page – Dynamic page for a collection clubs
  * Add club page – Page for inserting new club to be displayed by Club page
  * Club details page – Page for displaying a club information and list of registered players
  * Manage players page – Page for adding, reassigning and deregistering players
* Add branding, images, and styling (CSS) for the home page.
* Include navigation to the sub-pages outlined above.
* Any styling (CSS) should be used throughout the site, and can be modified from a single location.
* Use Razor pages to achieve consistent design and code reuse across the collected pages.
* Populate all pages (except the Home page) with appropriate static content based on their descriptions.
* All pages may be static, and include non-functional elements or placeholder outputs.

#### Part 2
* In the Views\Shared folder, create an empty partial view for form-based inputs.
* Update the Add Club Page to:
  * Include the partial view.
  * Include a save button.
  * Include a cancel button to return to the home page.
* All pages should use a layout file for their styling and shared content.
* In the Models folder, create the appropriate classes to represent your clubs and players. Populate these classes with any necessary members.
* Update the partial view to dynamically include labels and inputs for each property of the club model.
* In the Models folder, create a repository class to hold club data in a series of collections.
* When the user clicks the save button on the Insert Club Page, persist the form data to the repository collections.
* Update the Club Page to display a list of items from the repository.
  * Clicking a club item should load the Club Details Page with all the details.
  
  #### Part 3
* Create a class(s) to support Entity Framework and to implement your repository interface.
* In the Models folder, create a SeedData class to populate your database with initial data.
  * Add the code to run include this data if the database is empty.
* Generate the migration files to implement your database via Entity Framework.
* Implement a CRUD controller
* Update the Club Details Page to include an update and delete button. Load an update page via the CRUD controller to handle updating, or deleting, the item in the database.
* Update the Club Details page to show the list of players for the club and allow to add player to a club by navigating to the Manage players page.
* On the Manage players page, add the functionality for users to add a player(s) to a club

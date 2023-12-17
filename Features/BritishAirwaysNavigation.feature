Feature: British Airways Website Navigation

Validates different navigation in British Airways Home page

@BritishAirwaysNavigations
  Scenario: Verify navigation to the British Airways Website
    Given the user is on the Browser
    When the user navigates to URL "https://www.britishairways.com/travel/home/public/en_gb/"
    Then the user should be on the home page and title should be "British Airways | Book Flights, Holidays, City Breaks & Check In Online"


@BritishAirwaysNavigations
  Scenario: Verify navigation to the Main Menu Discover
    Given the user is on the British Airways home page
    When the user selects main menus "Discover"
    Then the user should be able to see the sublinks under Discover


@BritishAirwaysNavigations
  Scenario: Verify navigation to the Main Menu Book
    Given the user is on the British Airways home page
    When the user selects main menus "Book"
    Then the user should be able to see the sublinks under Book

    @BritishAirwaysNavigations
  Scenario: Verify navigation to the Main Menu Manage
    Given the user is on the British Airways home page
    When the user selects main menus "Manage"
    Then the user should be able to see the sublinks under Manage

        @BritishAirwaysNavigations
  Scenario: Verify navigation to the Main Menu Help
    Given the user is on the British Airways home page
    When the user selects main menus "Help"
    Then the user should be able to see the sublinks under Help





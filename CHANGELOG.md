# Changelog

## 0.0.2-alpha

* Major code refactor to improve readability and testability moving forward.

### New Endpoints

* ```GetScoreboard(string date)``` - Returns a scoreboard summary for the given date. Can be used to get GameIds.
* ```GetTeamRosterBySlugAsync(string year, string teamSlug)``` - Returns a list of playerIds for a given team and year. Used to get PlayerIds to make other calls.
* ```GetLeadTrackerAsync(string gameDate, string gameId, string period)``` - Gets a list of containing the clock time, lead team id, and points for a given period.


## 0.0.1-alpha

* Initial commit.

### New Endpoints

* ```GetPlayerBio(string playerId)``` - Returns a list of playerIds for a given team and year.

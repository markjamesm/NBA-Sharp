# Changelog

## 0.0.2-alpha

* Major code refactor to improve readability and testability moving forward.

### New Endpoints

* GetScoreboard(string date) - Returns a scoreboard summary for the given date. Can be used to get GameIds.
* GetTeamRosterBySlugAsync(string year, string teamSlug) - Returns a list of playerIds for a given team and year. Used to get PlayerIds to make other calls.


## 0.0.1-alpha

* Initial commit.

### New Endpoints

* GetPlayerBio(string playerId) - Returns a list of playerIds for a given team and year.

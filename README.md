## Introduction

This is a .Net Core solution to presents how to use the Hacker News API, that is documented here: https://github.com/HackerNews/API.

The method ListBestStories() returns the 20 "best stories" from Hacker News sorted by their score in a descending order. To do that, it get the stories IDs from https://hacker-news.firebaseio.com/v0/beststories.json and after the details of each story from https://hacker-news.firebaseio.com/v0/item/X.json (where X is the story  ID).

## Improvements
This is the first version, there some improveds to be done:
- Add unit test
- Use appsetting.json insted constants, as explain here https://github.com/fernandoprass/HackerNewsApiReader/blob/master/src/API/Helpers/Constant.cs

## NuGet Packages
One external package was added to the project
- **Newtonsoft.Json** => Serialize/Deserialize Json files (https://www.newtonsoft.com/json)

## How to test the API

To test the API:
1. Build and run the API
2. Call =>: [http://localhost:55355/api/Story/ListBestStories] 


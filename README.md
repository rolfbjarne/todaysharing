Today Sharing
=============

A very simple example of an app that shares information
between a today sharing extension and the app.

Certificates, Profiles, etc
===========================

1. Find "Certificates, Identifiers & Profiles" in Apple's Developer site.
2. Add a new Identifiers/App Group, following the instructions (for instance 'group.com.example.todaysharing')
3. Add a new Identifiers/App ID.
   * Check "Explicit App ID", for instance 'com.example.todaysharing'
   * Check App Services / App Groups
   * Continue
   * Select the recently created App ID, click Edit at the bottom.
   * Edit the App Groups
   * Check the previously created App Group and Continue.
   * Repeat once, creating an App ID for the extension, for instance 'com.example.todaysharing.todaysharingextension'
4. Add a new Provisioning profile
   * Select iOS App Development
   * Select the recently created App ID.
   * Select users and devices as desired.
   * Repeat once for the extension's App ID.
5. Modify the project to use your own information:
   * Set TodaySharing's iOS Application's bundle identifier to 'com.example.todaysharing'
   * Open TodaySharing/Entitlements.plist and change the existing app group id to 'group.com.example.todaysharing'
   * Open TapCounter/Entitlements.plist and change the existing app group id to 'group.com.example.todaysharing'

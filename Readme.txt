ComponentsLife
========================================

This app is deployed on Microsoft Azure
It can also be run locally, by cloning this repo and building the app using Visual Studio 2015.

Logins for testing: username: niall+review@niallquinn.me password: *Review123

======================================
Usage
======================================

Create instances of Engines, Brakes, Drivetrains and Supension to use in events. These instances have a property 'maxKilometers', which indicate at which point they should be changed for another part.

Creat instances of Events, and choose which parts were installed on the car for these events. These parts will have the distance travelled in that event added to their total in the summary view.

The summary view shows Events ordered by date along the X-Axis, and Parts along the Y-Axis. In the intersection we see which part was installed on the car for that event, how many kilometers have been travelled on the part, and also the max allowed kilometers for the part. The color will turn from green to red when it is time to change the part.

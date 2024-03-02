# UpgradeSystemWithDecorator
 A simple, yet useful, upgrade system created using the Decorator design pattern

 # Decorator is a structural design pattern that lets you attach new behaviors to objects by placing these objects inside special wrapper objects that contain the behaviors.

 - By using the decorator design pattern in the upgrade system, we're able to dynamically create a stack of upgrades
 - We're able to override the TriggerUpgrade and UntriggerUpgrade methods of the Upgrade class in order to create the functionality of a new upgrade
 - Call the AddUpgrade method in the PlayerUpgrades class in order to add a new upgrade and automatically trigger its effect.

# CDA World

Requirements:

- [x] There is a First Person Camera through witch the user perceives the world. We call this controllable camera the Avatar.
- [x] The Avatar that can be moved and rotated by the user
- [x] The User is able to use the mouse cursor at all times
- [x] The Avatar can be controlled by interchangeable input methods (e.g. Keyboard/Mouse, KeyboardOnly or both)
- [x] The User can click on interactable objects ~~which then will turn green~~. Objects that are not interactable will not be affected.
  - [x] Any object can be set up to be interactable
- [ ] The Avatar moves to a specific object automatically by clicking on it
  - [x] The object will become `selected` when clicked. Selected objects are yellow.
  - [x] The avatar should use the shortest path to reach the selected object.
  - [ ] While the Avatar moves to the selected object, no additional movement input will be processed.
  - [ ] Once the Avatar reached the selected object, the camera will look at the object more closely. The object becomes `active` and it's color turns green.
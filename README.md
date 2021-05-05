# PhysicsEngine

This is a basic WinForms, Cpu based physics simulator that you can run by using the installer located at Setup/Release/Setup.msi. The purpose of this project was to test the limits of what could be done in WinForms with Gdi on the cpu.

The engine features a 3 emitter particle engine that emits quad particles, which can do the following things:

* Emit a particle with a basic force simulation and trajectory
* Click me button that allows you to emit a particle
* Allows a "Max Particle Count" limit the particle count
* An auto particle emission that will cause the app to push out particles until the max limit is reached
* A size slider than will size the particles that are going to be emitted in real time
* A rotation slider that allows you to adjust the rotation of all particles in real time (This rotation is slightly buggy and rotates around a corner instead of the center)
* A multiplier that will cause the particle emitters to emit more than 1 particle at a time, up to 10 at a time per emitter.
* Particle shadows that follow the particles
* An FPS counter
* A particle counter
* A pause button that will freeze and unfreeze the simulation
* A reset button that will reset the particles (note that the simulation must be in an unpaused state for this to take effect, and click reset while paused will trigger the reset when unpaused)

** Additionally, the emitter can be run in debug to get an additional feature where click the mouse causes a force to be emitted in the surrounding area, which will fling the particles around.
** You can also hold down click on the debug verion of the particle engine to cause a suction, and when released, a force to be emitted to all affected particles

The ballistics engine is an incomplete simulation of very trivial ballistic physics. It can simulate an arrow, cannon ball or mortar, a laser with acceleration, and a standard bullet with drop.

Feel free to extend this any way you wish. Wpf could likely be used to make the rendering a gpu bound operation for much, much faster runtimes.

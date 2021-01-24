# Robot App

## Technology
The application is developed in .NET Core 3.1

## Design

**Terminology:**
- Toy: An object with some characteristics that can be interacted with.
- Boundary: A restriction placed on the Toy in order to control its interactive area.
- Platform: A logical place where the Toy is placed upon.

**The application is designed with the following consideration for future extension:**
- There can be any kind of Toy with different characteristics. The current implementation is a Toy Robot that can turn directions and walk one step at a time.
- There can be any kind of Boundary with different shapes and sizes.
- There must only be one platform.

## Design Patterns

### Singleton
Singleton pattern is used to restrict the application to have only one platform where the toy is placed upon.

### Command
Command pattern is used to encapsulate each supported action (PLACE, MOVE, LEFT, RIGHT, REPORT).

### Factory Method
Factory method is used in Toy creation and Command creation.

### Strategy
Strategy pattern is used to set different Move and Rotate behavior for the toy.

## Running the App
To run the app on docker, execute the following commands:

```
> cd /toy-robot/Source
> docker build -t robotapp -f Dockerfile .
> docker run -it --rm robotapp
```

# Press
***Press*** will be a simple blog engine created as an ASP.NET Core middleware

## Goals

I am creating this with 2 primary and selfish goals in mind

1. To modernize the look and migrate my current [blog](http://kelps.net "kelps.net") from Blogger to Azure
2. As a way to study and learn ASP.NET Core

Here are some of the main points I have in mind for this project:

- Simple and flexible blogging engine to be referenced as a NuGet package
- Configurable as middleware
  - Extensible repository services for content and media
  - Customizable routes
- Support for Open Live Writer (previously known as Windows Live Writer)
- Comes with simple built-in views but supports full view customization
- As little external dependencies as possible. 
  - this includes the default views' client side styling and scripting

## Distribution

I am planning on running CI builds and tests in my personal VSTS account. 
As soon as the code is usable in some form, I'll create a MyGet feed for it.

When it gets stable it'll be published to NuGet.

## Roadmap

### first release
- Simple support for posts with categories and future publish dates
  - no admin area
  - no internal comments
  - full custom views support
  - Open Live Writer support

### second release
- Admin area 
  - define blog settings
  - create and manage posts
- Simple internal comment engine support

## Contributions

Contributions will be most appreciated, specially for finding/fixing bugs, adding unit tests and code architecture/structure ideas and suggestions. 
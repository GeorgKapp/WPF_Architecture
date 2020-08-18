# WPF_Architecture

Custom Solution to demonstrate different architectural solutions for the WPF framework

Current Projects:
  MVVM
    Classic MVVM Structure where the ViewModel contains the data the View can access and also Command Options for different Actions on the View
    
  Custom Architecture (MVVMC)
    Architecture that adds a "controller" so the work of the "viewmodel" is split:
      now there are custom "viewmodels" ("models" that can be used by the "view" via notifypropertychanged event)
      a "controller" that returns "viewmodels" or manipulates them and uses services to retrieve/manipulate "models"
      adds PropertyChanged.Fody that allows for a custom wpf window class and custom viewmodel base class that adds the notifypropertychanged event to all properties in a class or derived class
      
      overall reduces time spent writting code because of architectural pattern
      allows for a classic service based backend structure
      adds readability to the code that mvvm lacks for non wpf programmers

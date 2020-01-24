# Description

### This application was developed in WPF APP .NetCore 3.0.

This project serves as a demonstration of a multilanguage application that obtains its data from an ASP.NET Core 3 Web API that can be seen at this link:
https://github.com/rdfernandes/MedicalExamsWebAPI


Basically it is an application with 3 screens distributed as follows:

### First screen:

![First Screen](https://raw.githubusercontent.com/rdfernandes/MedicalExams/master/screen1.png)

On this screen, as soon as it opens, a list with all the records obtained in a given call to the Web API is immediately displayed. This record is summarized in this listing.

### Second screen:

![Second Screen](https://raw.githubusercontent.com/rdfernandes/MedicalExams/master/screen2.png)

When you click on one of the records obtained on the first screen, this second screen is called where it presents in detail all the information existing in the record that we clicked on the first screen.

### Third screen:

![Third Screen](https://raw.githubusercontent.com/rdfernandes/MedicalExams/master/screen3.png)

On the first screen there is a button in the lower right corner, which calls this screen.
Here is presented a form with REGEX validation in its fields and that after completely filled, the button that allows its sending is activated.
In this form there is a list of options that are also obtained from the Web API but from another query / call.
This submission will be made to the Web API and these data will be saved in a database.
These same records are the records obtained on screen 1.


This application validates the internet connection and informs you when it is not available.
It has an external settings file where you must put the correct Web API address.



# DEMO

You can test the application using the files inside the `Publish` folder.
After downloading to your machine, simply update your Web API address in the `Settings.config` file and then run the application via the `MedicalExams.exe` file`.



## Cool Links

WPF: https://www.wpf-tutorial.com/

FontAwesome: https://www.meziantou.net/using-fontawesome-in-a-wpf-application.htm

Circular Buttons: https://markheath.net/post/circular-wpf-button-template

Web API: http://www.macoratti.net/16/06/webapi_cons5.htm | https://auth0.com/blog/how-to-build-and-secure-web-apis-with-aspnet-core-3/ | https://jsonplaceholder.typicode.com/

DatePicker: (maxDate: https://stackoverflow.com/questions/32577168/setting-mindate-and-maxdate-for-datepicker-control) | (label inside DatePicker TextBox: https://social.msdn.microsoft.com/Forums/vstudio/en-US/9e849e07-b932-4009-9af1-e8561ddfc801/how-to-display-select-a-date-text-in-datepicker?forum=wp)

Notifications: https://github.com/Federerer/Notifications.Wpf


##### Author: Ricardo Fernandes

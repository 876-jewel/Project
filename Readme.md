
**Groups**:
***JPS**: Davian & Jevon
**NBS**: Graig & Marie
**NCB**: Ricardo*

# Making new git proj:

**(READ DIS!!! CHANGE NCB TO UR BRANCH+NAME like JPS)**

Create an empty folder, name it whatever you want then open command prompt and navigate to folder, example:

    cd c:/nameoffolder

then type 

    git init

thennnn...
### (To Create the branch)

    git clone https://gitlab.com/Ricxx/ec2project.git
    git checkout -b NCB 
    git remote add origin https://gitlab.com/Ricxx/ec2project.git 
    git push origin NCB


### If Branch is Created already(by your teammate)

    git clone https://gitlab.com/Ricxx/ec2project.git
    git remote add origin https://gitlab.com/Ricxx/ec2project.git
    git checkout NCB
    git pull


#### Workflow:
You will be working with your teammate on your section of project, it will be easier if you work on separate files, if you both edit the same file then one person will have to merge files before the next can pull the file. Once merged the person should then be able to push files.

So the flow goes a bit like this, you both work on the branch, teammate A pushes their updated files to the repository, teammate B tries to push his/her updates but must first pull teammate's A changes and merge them into his/her files then push it to the repository to ensure everything is up to date. You should always check if your branch is up to date before you start working so you can avoid problems by pulling the latest.

    git pull origin NCB
    git add .
    git commit -m "Changed xyz files/Added xyz features"
    git push

**(IDK HOW TO MERGE YET, if you need to, watch a yt video)**


Pull from other branches into your branch.
If someone else implemented a feature you need and it hasn't been merged into master as yet you can still put it by doing:

    git pull origin NCB

OR

    git pull origin JPS

OR 

    git pull origin NBS

Idk how it works fully so you'll probably have to merge all the files and shit because you'll have 1 set of files which are more updated etc etc.


## File Structure:

For each file/webform you create, try to keep it within div tags and ***always right click > add new page from "site.master"*** makes it easier to edit in the future

as for files, try to have everything as a component, so if you have a form and a paragraph of text and a box it would be something like:

    <div>
    	<form>
    		Form code here, inputs etc
    	</form>
    </div>
    <div>
    	<p>
    		paragraph text here etc
    	</p>
    </div>
    <div>
    	This is a box...
    </div>

This is to ensure styling is much easier in the future whenever we need to.

## Things to Do:

We are using identity framework, this means we might have to find out how to add additional fields to the registration page, etc etc.
Databases need to be made etc etc.

## Resources(Useful links etc)

What is Windows Communication Framework: https://docs.microsoft.com/en-us/dotnet/framework/wcf/whats-wcf

Windows Communication Framework Samples
https://www.microsoft.com/en-us/download/details.aspx?id=21459

Git in 20 minutes
[https://www.youtube.com/watch?v=Y9XZQO1n_7c](https://www.youtube.com/watch?v=Y9XZQO1n_7c)

Edited by: [https://stackedit.io/app](https://stackedit.io/app)

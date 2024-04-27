# CSharp_CompanyManagement_InterfacingCommands
A Smaller Project In Which Works Upon Our Given C# Code In Repo <a href="https://github.com/Kingerthanu/CSharp_CompanyManagement">CSharp_CompanyManagement</a> To Implement Organization Changes Through The IOrgChange Interface And It's Constituent Valid Subclasses. This Simply Allows Us To Query In Either
a Hire Operation, Team Creation Operation, Or Employee Transfer Operation. In Driver.cs We Have A Demo In Place In Which Requests A .txt Doc. While This Doc. Is Inferred To Be _demoCommands.txt, You Could Easily Swap This Or Directly Inject
Your Own .txt And It Will Work (Just The Invariants Expressed In The Demo May Be Wonk).

This Program Was Really Fun And Showed A More Realistic Application Of Our Code And Maybe How It Could Be Applied To A End-User As Giving Simple Command Access As Expressed In The Code Allows Someone of No Computer-Expertise To Know How To
Work With Our Code And Actually Apply It In Something They May Use In Their Field Of Work. This Taught Me A Lot About How To Visually Express Text In A Less Noisy Way and How To Properly Outline Our Demo Without Too Much Visual or Verbal Bloat.
While We Don't Sanitize The .txt Contents, It Further Taught Me About How Powerful Contract-Based Design Can Be As Input Sanitization Really Can Be A Drag Mainly When Reading In Lines Of A Doc.

<img src="https://github.com/Kingerthanu/CSharp_CompanyManagement_InterfacingCommands/assets/76754592/6331c185-f57e-4847-a897-c08f056a38ae" alt="Cornstarch <3" width="95" height="99">




----------------------------------------------

<img src="https://github.com/Kingerthanu/CSharp_CompanyManagement_InterfacingCommands/assets/76754592/4f7628dc-063d-47eb-aa67-6a5b76e375a9" alt="Cornstarch <3" width="55" height="49"> <img src="https://github.com/Kingerthanu/CSharp_CompanyManagement_InterfacingCommands/assets/76754592/4f7628dc-063d-47eb-aa67-6a5b76e375a9" alt="Cornstarch <3" width="55" height="49"> <img src="https://github.com/Kingerthanu/CSharp_CompanyManagement_InterfacingCommands/assets/76754592/4f7628dc-063d-47eb-aa67-6a5b76e375a9" alt="Cornstarch <3" width="55" height="49"> <img src="https://github.com/Kingerthanu/CSharp_CompanyManagement_InterfacingCommands/assets/76754592/4f7628dc-063d-47eb-aa67-6a5b76e375a9" alt="Cornstarch <3" width="55" height="49">
 

**The Breakdown:**

 This C++ Program Works With The Terminal As Well As A .txt Document To Read In Requested Actions On A Given Company From The User.

 When The Program Is Initialized It Wil Read For the _demoCommands.txt Document In The Same Directory As It. In This Text Document The User Will Specify A Single Command To Execute On The Company On Each Line. The Format Will Be As Follows:

 &nbsp; Creating Team: c [Team Name]

 &nbsp; Creating/Hiring Employee: h [New Employee Name]

 &nbsp; Transfer Employee To Team: t [A Employees Name] [Team To Move To **(Empty If None)**]


 The Program Will Then Interpolate What Each Of These Lines Will Corrospond To As A Unique Company Command Object Type.

 Of Our Command Objects, All Them Will Be Subclasses Overridng A Company Execution Held In The IOrgChange Interface. This Allows Us For Polymorphic Calls On Given Iterations Of Our IOrgChange.

 We Then Will Call Each Command In The Order They Were Read In So From Top Of File To Bottom In Call Order. During Each Of These, We Will Display A Demo Showing The Current States Of The Company Being Worked On. 

 The Program Is Well Structured And Powerful With The Way I Tried To Work With Data In More Low-Level Terms. This Program Though Overall Taught Me A Lot About Documentation And Ways To Interpret Multi-Level Hierachicial Systems. ThiS Specific Instance Also Taught Me A Lot About The Power Of Using Things Like Polymorphism As Much As You May See Necessary To A Degree As It Sounds Scary But Can Be Benefitcial When Applied In Certain Contexts. Reading Through Files Is Always Fun Too But Thankfullly This Program Doesn't Expect Ill Formatted Documents. Also Learning More About C# Is Starting To Make Me See The Beauty In This Language And Why Some People Prefer To Use It To Something More Saddening Like C++.

<img src="https://github.com/Kingerthanu/CSharp_CompanyManagement_InterfacingCommands/assets/76754592/23449854-a58d-4a73-99dd-72fc6a7c8b3e" alt="Cornstarch <3" width="55" height="49"> <img src="https://github.com/Kingerthanu/CSharp_CompanyManagement_InterfacingCommands/assets/76754592/23449854-a58d-4a73-99dd-72fc6a7c8b3e" alt="Cornstarch <3" width="55" height="49"> <img src="https://github.com/Kingerthanu/CSharp_CompanyManagement_InterfacingCommands/assets/76754592/23449854-a58d-4a73-99dd-72fc6a7c8b3e" alt="Cornstarch <3" width="55" height="49"> <img src="https://github.com/Kingerthanu/CSharp_CompanyManagement_InterfacingCommands/assets/76754592/23449854-a58d-4a73-99dd-72fc6a7c8b3e" alt="Cornstarch <3" width="55" height="49">

----------------------------------------------

<img src="https://github.com/Kingerthanu/CSharp_CompanyManagement_InterfacingCommands/assets/76754592/20a0dcec-8ca1-4685-9f3a-87e8c8261150" alt="Cornstarch <3" width="55" height="49"> <img src="https://github.com/Kingerthanu/CSharp_CompanyManagement_InterfacingCommands/assets/76754592/20a0dcec-8ca1-4685-9f3a-87e8c8261150" alt="Cornstarch <3" width="55" height="49"> <img src="https://github.com/Kingerthanu/CSharp_CompanyManagement_InterfacingCommands/assets/76754592/20a0dcec-8ca1-4685-9f3a-87e8c8261150" alt="Cornstarch <3" width="55" height="49"> <img src="https://github.com/Kingerthanu/CSharp_CompanyManagement_InterfacingCommands/assets/76754592/20a0dcec-8ca1-4685-9f3a-87e8c8261150" alt="Cornstarch <3" width="55" height="49">

**Features:**

_demoCommands.txt Contents:

<img width="472" alt="image" src="https://github.com/Kingerthanu/CSharp_CompanyManagement_InterfacingCommands/assets/76754592/65a1072a-d112-463c-9291-719e02761734">

![CompanyCSharp-ezgif com-optimize](https://github.com/Kingerthanu/CSharp_CompanyManagement_InterfacingCommands/assets/76754592/f6d582eb-a9a5-4838-b976-0bd9cb1d6ec8)

<img src="https://github.com/Kingerthanu/CSharp_CompanyManagement_InterfacingCommands/assets/76754592/88611206-daee-422a-ac3b-b394f54603b7" alt="Cornstarch <3" width="55" height="49"> <img src="https://github.com/Kingerthanu/CSharp_CompanyManagement_InterfacingCommands/assets/76754592/88611206-daee-422a-ac3b-b394f54603b7" alt="Cornstarch <3" width="55" height="49"> <img src="https://github.com/Kingerthanu/CSharp_CompanyManagement_InterfacingCommands/assets/76754592/88611206-daee-422a-ac3b-b394f54603b7" alt="Cornstarch <3" width="55" height="49"> <img src="https://github.com/Kingerthanu/CSharp_CompanyManagement_InterfacingCommands/assets/76754592/88611206-daee-422a-ac3b-b394f54603b7" alt="Cornstarch <3" width="55" height="49">


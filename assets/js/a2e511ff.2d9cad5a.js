"use strict";(self.webpackChunk_profio_app_source=self.webpackChunk_profio_app_source||[]).push([[255],{3905:(e,t,n)=>{n.d(t,{Zo:()=>u,kt:()=>h});var r=n(7294);function i(e,t,n){return t in e?Object.defineProperty(e,t,{value:n,enumerable:!0,configurable:!0,writable:!0}):e[t]=n,e}function s(e,t){var n=Object.keys(e);if(Object.getOwnPropertySymbols){var r=Object.getOwnPropertySymbols(e);t&&(r=r.filter((function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable}))),n.push.apply(n,r)}return n}function a(e){for(var t=1;t<arguments.length;t++){var n=null!=arguments[t]?arguments[t]:{};t%2?s(Object(n),!0).forEach((function(t){i(e,t,n[t])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(n)):s(Object(n)).forEach((function(t){Object.defineProperty(e,t,Object.getOwnPropertyDescriptor(n,t))}))}return e}function o(e,t){if(null==e)return{};var n,r,i=function(e,t){if(null==e)return{};var n,r,i={},s=Object.keys(e);for(r=0;r<s.length;r++)n=s[r],t.indexOf(n)>=0||(i[n]=e[n]);return i}(e,t);if(Object.getOwnPropertySymbols){var s=Object.getOwnPropertySymbols(e);for(r=0;r<s.length;r++)n=s[r],t.indexOf(n)>=0||Object.prototype.propertyIsEnumerable.call(e,n)&&(i[n]=e[n])}return i}var l=r.createContext({}),c=function(e){var t=r.useContext(l),n=t;return e&&(n="function"==typeof e?e(t):a(a({},t),e)),n},u=function(e){var t=c(e.components);return r.createElement(l.Provider,{value:t},e.children)},p="mdxType",d={inlineCode:"code",wrapper:function(e){var t=e.children;return r.createElement(r.Fragment,{},t)}},m=r.forwardRef((function(e,t){var n=e.components,i=e.mdxType,s=e.originalType,l=e.parentName,u=o(e,["components","mdxType","originalType","parentName"]),p=c(n),m=i,h=p["".concat(l,".").concat(m)]||p[m]||d[m]||s;return n?r.createElement(h,a(a({ref:t},u),{},{components:n})):r.createElement(h,a({ref:t},u))}));function h(e,t){var n=arguments,i=t&&t.mdxType;if("string"==typeof e||i){var s=n.length,a=new Array(s);a[0]=m;var o={};for(var l in t)hasOwnProperty.call(t,l)&&(o[l]=t[l]);o.originalType=e,o[p]="string"==typeof e?e:i,a[1]=o;for(var c=2;c<s;c++)a[c]=n[c];return r.createElement.apply(null,a)}return r.createElement.apply(null,n)}m.displayName="MDXCreateElement"},2883:(e,t,n)=>{n.r(t),n.d(t,{assets:()=>u,contentTitle:()=>l,default:()=>h,frontMatter:()=>o,metadata:()=>c,toc:()=>p});var r=n(7462),i=n(3366),s=(n(7294),n(3905)),a=["components"],o={title:"User Story",description:"A brief description of the user story",sidebar_position:5,last_update:{author:"Nguyen Xuan Nhan"}},l="User Story",c={unversionedId:"bussiness-scenario/userstory",id:"bussiness-scenario/userstory",title:"User Story",description:"A brief description of the user story",source:"@site/docs/bussiness-scenario/userstory.md",sourceDirName:"bussiness-scenario",slug:"/bussiness-scenario/userstory",permalink:"/ProfioApp/docs/bussiness-scenario/userstory",draft:!1,editUrl:"https://github.com/HutechCJ/ProfioApp/blob/main/apps/docs/docs/bussiness-scenario/userstory.md",tags:[],version:"current",lastUpdatedBy:"Nguyen Xuan Nhan",lastUpdatedAt:1696419484,formattedLastUpdatedAt:"Oct 4, 2023",sidebarPosition:5,frontMatter:{title:"User Story",description:"A brief description of the user story",sidebar_position:5,last_update:{author:"Nguyen Xuan Nhan"}},sidebar:"tutorialSidebar",previous:{title:"Event Storming",permalink:"/ProfioApp/docs/bussiness-scenario/event"},next:{title:"Work Breakdown Structure",permalink:"/ProfioApp/docs/bussiness-scenario/wbs"}},u={},p=[{value:"User Story 1: Real-time Vehicle Tracking",id:"user-story-1-real-time-vehicle-tracking",level:2},{value:"User Story 2: Efficient Route Planning and Mode Transition",id:"user-story-2-efficient-route-planning-and-mode-transition",level:2},{value:"User Story 3: Real-time Estimated Delivery Times",id:"user-story-3-real-time-estimated-delivery-times",level:2},{value:"User Story 4: Assigned Personnel Information",id:"user-story-4-assigned-personnel-information",level:2},{value:"User Story 5: Delivery Progress Monitoring",id:"user-story-5-delivery-progress-monitoring",level:2},{value:"User Story 6: Incident Management",id:"user-story-6-incident-management",level:2}],d={toc:p},m="wrapper";function h(e){var t=e.components,n=(0,i.Z)(e,a);return(0,s.kt)(m,(0,r.Z)({},d,n,{components:t,mdxType:"MDXLayout"}),(0,s.kt)("h1",{id:"user-story"},"User Story"),(0,s.kt)("h2",{id:"user-story-1-real-time-vehicle-tracking"},"User Story 1: Real-time Vehicle Tracking"),(0,s.kt)("p",{align:"justify"},(0,s.kt)("p",null,(0,s.kt)("strong",{parentName:"p"},"Title:")," Real-time Vehicle Tracking and Incident Response"),(0,s.kt)("p",null,(0,s.kt)("strong",{parentName:"p"},"As a")," logistics manager responsible for overseeing the timely and safe transportation of goods, ",(0,s.kt)("strong",{parentName:"p"},"I want to")," have the capability to track the precise location of transportation vehicles in real-time, primarily based on zip codes ",(0,s.kt)("strong",{parentName:"p"},"so that I can")," efficiently monitor their progress, ensure timely deliveries, and respond swiftly to any incidents that may arise."),(0,s.kt)("p",null,(0,s.kt)("strong",{parentName:"p"},"Acceptance Criteria:")),(0,s.kt)("ul",null,(0,s.kt)("li",{parentName:"ul"},"The system should provide a continuously updated map interface displaying the real-time locations of all transportation vehicles."),(0,s.kt)("li",{parentName:"ul"},"Vehicle location updates should occur at least every 60 seconds for accurate tracking."),(0,s.kt)("li",{parentName:"ul"},"In the event of a hub reporting an incident or a vehicle encountering a breakdown, the system should promptly identify the current zip code of the transporting vehicle."),(0,s.kt)("li",{parentName:"ul"},"Leveraging the hub information, the system must determine the nearest hub based on the vehicle's current zip code."),(0,s.kt)("li",{parentName:"ul"},"The system should calculate and display the shortest route from the vehicle's current location to the nearest hub."),(0,s.kt)("li",{parentName:"ul"},"Journey history, including timestamps and zip codes of each hub visited along the way, should be recorded and accessible for transparency and historical analysis."))),(0,s.kt)("h2",{id:"user-story-2-efficient-route-planning-and-mode-transition"},"User Story 2: Efficient Route Planning and Mode Transition"),(0,s.kt)("p",{align:"justify"},(0,s.kt)("p",null,(0,s.kt)("strong",{parentName:"p"},"Title:")," Efficient Route Planning and Mode Transition for Optimal Deliveries"),(0,s.kt)("p",null,(0,s.kt)("strong",{parentName:"p"},"As a")," logistics coordinator responsible for route planning and order fulfillment, ",(0,s.kt)("strong",{parentName:"p"},"I want the system to")," not only recommend the most suitable mode of transportation but also provide alternative routes in situations where the system cannot locate the nearest hub or where chosen routes become impassable due to unforeseen circumstances ",(0,s.kt)("strong",{parentName:"p"},"so that I can")," ensure cost-effective, timely deliveries while accommodating specific delivery requirements."),(0,s.kt)("p",null,(0,s.kt)("strong",{parentName:"p"},"Acceptance Criteria:")),(0,s.kt)("ul",null,(0,s.kt)("li",{parentName:"ul"},"The system should automatically alert logistics coordinators when it cannot locate the nearest hub or when chosen routes become impassable due to incidents, road closures, or other impediments."),(0,s.kt)("li",{parentName:"ul"},"In such cases, the system should offer alternative route suggestions, considering factors like distance, expected travel time, and the availability of suitable transportation modes."),(0,s.kt)("li",{parentName:"ul"},"Recommendations should include the option to transition between transportation modes, such as suggesting a switch from a truck to a motorcycle for intra-city deliveries or vice versa for inter-provincial shipments."),(0,s.kt)("li",{parentName:"ul"},"The system should provide detailed route instructions and communicate these recommendations to relevant staff members responsible for executing deliveries."))),(0,s.kt)("h2",{id:"user-story-3-real-time-estimated-delivery-times"},"User Story 3: Real-time Estimated Delivery Times"),(0,s.kt)("p",{align:"justify"},(0,s.kt)("p",null,(0,s.kt)("strong",{parentName:"p"},"Title:")," Real-time Estimated Delivery Times for Enhanced Customer Satisfaction"),(0,s.kt)("p",null,(0,s.kt)("strong",{parentName:"p"},"As a")," customer service representative responsible for managing customer expectations, ",(0,s.kt)("strong",{parentName:"p"},"I want the system to")," continuously update and communicate precise estimated delivery times to customers, suppliers, and other stakeholders, ",(0,s.kt)("strong",{parentName:"p"},"so that I can")," provide accurate and up-to-the-minute delivery expectations, thereby enhancing overall customer satisfaction."),(0,s.kt)("p",null,(0,s.kt)("strong",{parentName:"p"},"Acceptance Criteria:")),(0,s.kt)("ul",null,(0,s.kt)("li",{parentName:"ul"},"The system should provide real-time updates on estimated delivery times for each order, considering variables like vehicle location, route optimization, and historical delivery performance."),(0,s.kt)("li",{parentName:"ul"},"Estimated delivery times should be accessible to both customers and internal stakeholders through the system's user interface."),(0,s.kt)("li",{parentName:"ul"},"Customers should receive proactive notifications with estimated delivery timeframes, improving their experience and reducing inquiries related to delivery status."),(0,s.kt)("li",{parentName:"ul"},"The system should also allow customer service representatives to access and communicate these estimations to customers when needed, ensuring clear and accurate communication."))),(0,s.kt)("h2",{id:"user-story-4-assigned-personnel-information"},"User Story 4: Assigned Personnel Information"),(0,s.kt)("p",{align:"justify"},(0,s.kt)("p",null,(0,s.kt)("strong",{parentName:"p"},"Title:")," Vehicle Personnel Assignment for Improved Accountability and Communication"),(0,s.kt)("p",null,(0,s.kt)("strong",{parentName:"p"},"As a")," fleet manager responsible for personnel and vehicle management, ",(0,s.kt)("strong",{parentName:"p"},"I want the system to")," efficiently associate each vehicle with designated staff members responsible for their operations, ",(0,s.kt)("strong",{parentName:"p"},"so that I can")," promote accountability, facilitate seamless communication, and enhance problem-solving capabilities during transit."),(0,s.kt)("p",null,(0,s.kt)("strong",{parentName:"p"},"Acceptance Criteria:")),(0,s.kt)("ul",null,(0,s.kt)("li",{parentName:"ul"},"The system should have a personnel assignment module that enables fleet managers to link each vehicle with a designated staff member."),(0,s.kt)("li",{parentName:"ul"},"Personnel information should encompass essential details, including contact information (phone number and email), roles (driver, shipper, etc.), responsibilities (e.g., primary driver or backup), and performance records (e.g., incident history and on-time delivery metrics)."),(0,s.kt)("li",{parentName:"ul"},"Fleet managers and designated staff members should have the ability to view and update personnel assignments through the system's user interface."),(0,s.kt)("li",{parentName:"ul"},"The system should allow for notifications or alerts to be sent to responsible personnel in the event of incidents, route changes, or other critical information."))),(0,s.kt)("h2",{id:"user-story-5-delivery-progress-monitoring"},"User Story 5: Delivery Progress Monitoring"),(0,s.kt)("p",{align:"justify"},(0,s.kt)("p",null,(0,s.kt)("strong",{parentName:"p"},"Title:")," Comprehensive Delivery Progress Monitoring"),(0,s.kt)("p",null,(0,s.kt)("strong",{parentName:"p"},"As a")," customer support agent responsible for ensuring smooth deliveries and addressing customer inquiries, ",(0,s.kt)("strong",{parentName:"p"},"I want the system to")," maintain a comprehensive record of the delivery progress for each order, providing detailed insights into the journey, any exceptional circumstances encountered, estimated time to completion, and specific notes or comments ",(0,s.kt)("strong",{parentName:"p"},"so that I can")," proactively address issues, keep customers informed, and engage in effective communication."),(0,s.kt)("p",null,(0,s.kt)("strong",{parentName:"p"},"Acceptance Criteria:")),(0,s.kt)("ul",null,(0,s.kt)("li",{parentName:"ul"},"The system should continuously update and display the progress of each delivery order."),(0,s.kt)("li",{parentName:"ul"},"The delivery progress record should include details such as the percentage of the journey completed, the estimated time to completion, exceptional circumstances encountered (e.g., traffic delays or adverse weather conditions), and specific notes or comments from staff members involved in the delivery."),(0,s.kt)("li",{parentName:"ul"},"Customer support agents should be able to access this information through the system's user interface."),(0,s.kt)("li",{parentName:"ul"},"The system should enable agents to send timely notifications to customers regarding any changes in delivery status or unexpected delays, improving overall customer satisfaction."))),(0,s.kt)("h2",{id:"user-story-6-incident-management"},"User Story 6: Incident Management"),(0,s.kt)("p",{align:"justify"},(0,s.kt)("p",null,(0,s.kt)("strong",{parentName:"p"},"Title:")," Efficient Incident Management for Quick Resolution and Process Improvement"),(0,s.kt)("p",null,(0,s.kt)("strong",{parentName:"p"},"As an")," incident analyst responsible for post-incident analysis and resolution, ",(0,s.kt)("strong",{parentName:"p"},"I want the system to")," provide a robust incident management module that records and categorizes all incidents occurring at hubs or involving vehicles, capturing crucial details such as the time of occurrence, nature of the incident, involved parties, and comprehensive descriptions, ",(0,s.kt)("strong",{parentName:"p"},"so that I can")," analyze incidents, facilitate efficient resolution, and contribute to process improvement initiatives."),(0,s.kt)("p",null,(0,s.kt)("strong",{parentName:"p"},"Acceptance Criteria:")),(0,s.kt)("ul",null,(0,s.kt)("li",{parentName:"ul"},"The system should feature a dedicated incident management module accessible to authorized personnel."),(0,s.kt)("li",{parentName:"ul"},"It should allow users to record incident details, including the precise time of occurrence, the nature of the incident (e.g., breakdown, accident, or security breach), the parties involved (e.g., drivers, shippers, or staff at hubs), and comprehensive descriptions of what transpired."),(0,s.kt)("li",{parentName:"ul"},"Recorded incident data should be stored securely and be available for post-incident analysis, resolution, and process improvement initiatives."),(0,s.kt)("li",{parentName:"ul"},"The system should also enable the efficient retrieval of incident records for reporting and compliance purposes."))))}h.isMDXComponent=!0}}]);
# Lathander

## How to use:
Sent POST request to "processMessage" endpoint with request containing IBT message in body (if message is null default message will be used from file inside Lathander.Api/App_Data). 
Processed message will be, for one client, saved inside partner-b-output folder and for other will be logged as a e-mail body.

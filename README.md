## Running directives
- docker pull rabbitmq:3.12-management
- docker run -d --name rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:3.12-management

## Startup projects
Multiple startup projects defined (in the following order):
- MessageQueueReciever (console application)
- MessageQueueSender (console application)
- WebApiLearning (docker by default)
- FrontEnd (docker by default)

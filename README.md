# Skr3D
#项目介绍<br> 
这是一个基于.Net Core 3.1设计的DDD框架，只是简单的DDD内容。<br> 
使用了原生DI做依赖注入，接口化编程更易于扩展。<br> 
使用了MediatR做业务上的读写分离<br> 
使用了MediatR做了领域事件<br> 
用EntityFramework做orm框架，配合CodeFirst让开发者只关注领域对象。<br> 

## 分层
### Skr3D.UI Api层

## Skr3D.Application  应用层
这是很薄的一层，在这里使用MediatR配合Api层的注入，实现业务上的读写分离。<br> 

## Skr3D.Domain 领域层
### Skr3D.Domain 领域层
领域对象，领域事件，领域处理等。<br>
### Skr3D.Domain.Core 领域核心层
领域层的抽象部分。<br>

## Skr3D.Infrastruct 基础设施层
### Skr3D.Infrastruct 基础设施层
公共可调用的类和方法等。<br>
### Skr3D.Infrastruct.Data 基础设施数据层
数据持久化层，将领域层内容持久化到数据库。<br>

## PS
此项目大家提交的时候不要提交到master分支，请自己创建分支提交，谢谢大家。<br>
为了.Net社区，大家一起努力吧！<br>

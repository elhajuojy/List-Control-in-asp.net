create database dropDownList
use dropDownList


create table tbContinents (
 ContinentsId int primary key identity ,
 ContinentsName varchar(40)
)


create table tbCountry (
 CountryId int primary key identity ,
 CountryName varchar(40),
  ContinentsId int foreign key references tbContinents(ContinentsId)  ,

)

create table tbCity (
 CityId int primary key identity ,
 CityName varchar(40),
  CountryId int foreign key references tbCountry(CountryId)  ,

)


create procedure spGetContinents
as 
begin
select ContinentsId , ContinentsName from tbContinents
end


create procedure spGetCountrybyContinentsID
@ContinentsId int
as 
begin
 select CountryId ,CountryName from tbCountry
           where ContinentsId = @ContinentsId
end



create procedure spGetCitybyCountryID
@CountryId int
as 
begin
 select  CityId,CityName from tbCity
           where CountryId = @CountryId
end

// See https://aka.ms/new-console-template for more information
using AdapterPattern;

string SampleXml = @"<?xml version='1.0' encoding='UTF-8' standalone='yes'?>
<notedto>
    <to>Shivaraj</to>
    <from>Hiremath</from>
    <heading>Shivaraj Hiremath</heading>
    <body>Shivaraj details</body>
</notedto>
";

Console.WriteLine("Adapter Pattern");

IXmlParser<NoteDto> parser = new XmlParser<NoteDto>();
var note = parser.Parse(SampleXml);
Console.WriteLine(parser.ConvertToXml(note));

//using Adapter Pattern, Convering xml(existing) to Json(Client requested)
IJsonParser<NoteDto> clientRequestedParser = new XmlToJsonAdapter<NoteDto>();
var notes = clientRequestedParser.Parse(SampleXml);
Console.WriteLine(clientRequestedParser.ConvertToJson(notes));

Console.ReadLine();
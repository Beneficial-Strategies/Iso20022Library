// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Framework;
using BeneficialStrategies.Iso20022.SimpleTypes;

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// Reading into an interface: the reader asks a factory for the object, sets its properties and returns it.
/// The interfaces and classes here are the tests' own, no record is involved.
/// </summary>
public class InterfaceReadingTests
{
    [IsoMessage("tst.001.001.01", "Tst", "urn:test:tst")]
    public interface ITstMessage : IOuterRecord
    {
        [IsoXmlTag("Hdr")]
        ITstHeader Header { get; }

        [IsoXmlTag("Itm")]
        IEnumerable<ITstItem> Items { get; }

        [IsoXmlTag("Pty")]
        ITstParty? Party { get; }
    }

    public interface ITstHeader : IIsoComponent
    {
        [IsoXmlTag("Id")]
        Max35Text Identification { get; }

        [IsoXmlTag("Nm")]
        Max35Text? Name { get; }
    }

    public interface ITstItem : IIsoComponent
    {
        [IsoXmlTag("Ref")]
        string Reference { get; }
    }

    public interface ITstParty : IIsoChoice { }

    [IsoXmlTag("Org")]
    public interface ITstOrganisation : ITstParty, IIsoChoiceVariant
    {
        [IsoXmlTag("Nm")]
        Max35Text Name { get; }
    }

    public interface ITstCode : ITstParty, IIsoChoiceVariant
    {
        [IsoXmlTag("Cd")]
        Max35Text Code { get; }
    }

    // The classes a factory would make: a settable property for each property of the interface, and nothing else.
    public sealed class Message : ITstMessage
    {
        public ITstHeader Header { get; set; } = null!;
        public IEnumerable<ITstItem> Items { get; set; } = null!;
        public ITstParty? Party { get; set; }
    }

    public sealed class Header : ITstHeader
    {
        public Max35Text Identification { get; set; }
        public Max35Text? Name { get; set; }
    }

    public sealed class Item : ITstItem
    {
        public string Reference { get; set; } = null!;
    }

    public sealed class Organisation : ITstOrganisation
    {
        public Max35Text Name { get; set; }
    }

    public sealed class CodeChoice : ITstCode
    {
        public Max35Text Code { get; set; }
    }

    private sealed class TestFactory : IIsoDataFactory
    {
        public int Made { get; private set; }

        public object Create(Type type)
        {
            Made++;
            if (type == typeof(ITstMessage)) return new Message();
            if (type == typeof(ITstHeader)) return new Header();
            if (type == typeof(ITstItem)) return new Item();
            if (type == typeof(ITstOrganisation)) return new Organisation();
            if (type == typeof(ITstCode)) return new CodeChoice();
            throw new NotSupportedException(type.Name);
        }
    }

    private const string Ns = "urn:test:tst";

    private static string Xml(string body) => $"<Document xmlns=\"{Ns}\"><Tst>{body}</Tst></Document>";

    private const string Full =
        "<Hdr><Id>H-1</Id><Nm>Name</Nm></Hdr><Itm><Ref>a</Ref></Itm><Itm><Ref>b</Ref></Itm><Pty><Org><Nm>Org</Nm></Org></Pty>";

    [Fact]
    public void AMessage_IsReadIntoTheObjectsOfTheFactory()
    {
        var factory = new TestFactory();

        var result = Iso20022XmlSerializer.TryRead<ITstMessage>(Xml(Full), factory);

        Assert.True(result.Succeeded, string.Join("; ", result.Issues));
        var message = result.Message!;
        Assert.IsType<Message>(message);
        Assert.Equal("H-1", message.Header.Identification.Value);
        Assert.Equal("Name", message.Header.Name!.Value.Value);
        Assert.Equal(new[] { "a", "b" }, message.Items.Select(i => i.Reference));
        Assert.Equal("Org", Assert.IsAssignableFrom<ITstOrganisation>(message.Party).Name.Value);
        Assert.Equal(5, factory.Made);   // message, header, two items, organisation; nothing is asked for a leaf
    }

    [Fact]
    public void AVariantWithOneMember_IsFoundByThatMembersTag()
    {
        var result = Iso20022XmlSerializer.TryRead<ITstMessage>(Xml("<Hdr><Id>H-1</Id></Hdr><Pty><Cd>X1</Cd></Pty>"), new TestFactory());

        Assert.True(result.Succeeded, string.Join("; ", result.Issues));
        Assert.Equal("X1", Assert.IsAssignableFrom<ITstCode>(result.Message!.Party).Code.Value);
    }

    [Fact]
    public void AnAbsentList_IsEmpty_NotNull_AndAnAbsentOptionalMember_IsNull()
    {
        var result = Iso20022XmlSerializer.TryRead<ITstMessage>(Xml("<Hdr><Id>H-1</Id></Hdr>"), new TestFactory());

        Assert.True(result.Succeeded, string.Join("; ", result.Issues));
        Assert.Empty(result.Message!.Items);
        Assert.Null(result.Message.Header.Name);
        Assert.Null(result.Message.Party);
    }

    [Fact]
    public void AMemberThatIsNotNullable_IsRequired()
    {
        var result = Iso20022XmlSerializer.TryRead<ITstMessage>(Xml("<Hdr><Nm>Name</Nm></Hdr>"), new TestFactory());

        Assert.False(result.Succeeded);
        var issue = Assert.Single(result.Issues);
        Assert.Equal(IssueCode.RequiredMissing, issue.Code);
        Assert.Equal("Document/Tst/Hdr/Id", issue.Path);
    }

    [Fact]
    public void ACorruptValue_IsReportedWithItsPath_AsForARecord()
    {
        var result = Iso20022XmlSerializer.TryRead<ITstMessage>(Xml(Full.Replace("<Id>H-1</Id>", "<Id>" + new string('x', 40) + "</Id>")), new TestFactory());

        Assert.False(result.Succeeded);
        Assert.Equal("Document/Tst/Hdr/Id", Assert.Single(result.Issues).Path);
    }

    [Fact]
    public void AChoiceWithNoVariantPresent_IsReported()
    {
        var result = Iso20022XmlSerializer.TryRead<ITstMessage>(Xml("<Hdr><Id>H-1</Id></Hdr><Pty><Other>x</Other></Pty>"), new TestFactory());

        Assert.False(result.Succeeded);
        Assert.Contains(result.Issues, i => i.Code == IssueCode.UnknownChoice && i.Path == "Document/Tst/Pty");
        Assert.Contains(result.Issues, i => i.Code == IssueCode.UnexpectedElement && i.Path == "Document/Tst/Pty/Other");
    }

    [Fact]
    public void WithoutAFactory_AnInterfaceCannotBeRead_AndTheErrorSaysWhatToDo()
    {
        var ex = Assert.Throws<InvalidOperationException>(() => Iso20022XmlSerializer.TryRead<ITstMessage>(Xml(Full)));

        Assert.Contains("IIsoDataFactory", ex.Message);
    }

    [Fact]
    public void WhatWasRead_IsWrittenBackAsTheSameXml()
    {
        var message = Iso20022XmlSerializer.TryRead<ITstMessage>(Xml(Full), new TestFactory()).Message!;

        var written = Iso20022XmlSerializer.SerializeToString(message);

        Assert.True(XNode.DeepEquals(XDocument.Parse(Xml(Full)).Root, XDocument.Parse(written).Root), written);
    }
}

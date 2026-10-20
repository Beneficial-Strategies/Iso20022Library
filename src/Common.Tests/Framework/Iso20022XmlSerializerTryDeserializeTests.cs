// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.pacs;
using BeneficialStrategies.Iso20022.Serialization;

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// Tests for <see cref="Iso20022XmlSerializer.TryDeserialize{TMessage}(string, out TMessage, out Exception)"/>
/// and its <see cref="XDocument"/> overload — the non-throwing counterpart to
/// <see cref="Iso20022XmlSerializer.Deserialize{TMessage}(string)"/>, built for handlers that
/// need parse failures to surface as data (a returned <see langword="false"/> plus an
/// <see cref="Exception"/>) rather than as a thrown exception.
/// </summary>
public class Iso20022XmlSerializerTryDeserializeTests
{
    private static MultilateralSettlementRequestV02 ValidMessage() =>
        new()
        {
            GroupHeader = new GroupHeader104
            {
                MessageIdentification = "MSG-001",
                CreationDateTime = new DateTime(2026, 1, 1),
                NumberOfSettlementRequests = "0",
            },
        };

    [Fact]
    public void TryDeserialize_String_ValidXml_ReturnsTrueWithMessage()
    {
        var xml = Iso20022XmlSerializer.SerializeToString(ValidMessage());

        var success = Iso20022XmlSerializer.TryDeserialize<MultilateralSettlementRequestV02>(
            xml,
            out var message,
            out var error
        );

        Assert.True(success);
        Assert.Null(error);
        Assert.NotNull(message);
        Assert.Equal("MSG-001", (string)message.GroupHeader.MessageIdentification);
    }

    [Fact]
    public void TryDeserialize_String_MalformedXml_ReturnsFalseWithXmlException()
    {
        var success = Iso20022XmlSerializer.TryDeserialize<MultilateralSettlementRequestV02>(
            "<Document><Unclosed>",
            out var message,
            out var error
        );

        Assert.False(success);
        Assert.Null(message);
        Assert.IsType<XmlException>(error);
    }

    [Fact]
    public void TryDeserialize_String_WrongRootElement_ReturnsFalseWithInvalidOperationException()
    {
        // Well-formed XML, but not this message's <Document>/<MulSttlmReq> shape.
        const string wellFormedButWrongShape = "<SomethingElse xmlns=\"urn:not-iso20022\"><Inner/></SomethingElse>";

        var success = Iso20022XmlSerializer.TryDeserialize<MultilateralSettlementRequestV02>(
            wellFormedButWrongShape,
            out var message,
            out var error
        );

        Assert.False(success);
        Assert.Null(message);
        Assert.IsType<InvalidOperationException>(error);
    }

    [Fact]
    public void TryDeserialize_String_Null_ReturnsFalseWithArgumentNullException()
    {
        var success = Iso20022XmlSerializer.TryDeserialize<MultilateralSettlementRequestV02>(
            (string?)null,
            out var message,
            out var error
        );

        Assert.False(success);
        Assert.Null(message);
        Assert.IsType<ArgumentNullException>(error);
    }

    [Fact]
    public void TryDeserialize_XDocument_ValidDocument_ReturnsTrueWithMessage()
    {
        var document = Iso20022XmlSerializer.Serialize(ValidMessage());

        var success = Iso20022XmlSerializer.TryDeserialize<MultilateralSettlementRequestV02>(
            document,
            out var message,
            out var error
        );

        Assert.True(success);
        Assert.Null(error);
        Assert.NotNull(message);
    }

    [Fact]
    public void TryDeserialize_XDocument_Null_ReturnsFalseWithArgumentNullException()
    {
        var success = Iso20022XmlSerializer.TryDeserialize<MultilateralSettlementRequestV02>(
            (XDocument?)null,
            out var message,
            out var error
        );

        Assert.False(success);
        Assert.Null(message);
        Assert.IsType<ArgumentNullException>(error);
    }
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.pacs;
using BeneficialStrategies.Iso20022.Serialization;

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// Tests for <see cref="Iso20022JsonSerializer"/> — a thin, symmetrical counterpart to
/// <see cref="Iso20022XmlSerializer"/>, whose main purpose is the non-throwing
/// <see cref="Iso20022JsonSerializer.TryDeserialize{TMessage}"/> entry point.
/// </summary>
public class Iso20022JsonSerializerTests
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
    public void SerializeToString_ThenDeserialize_RoundTrips()
    {
        var json = Iso20022JsonSerializer.SerializeToString(ValidMessage());

        var message = Iso20022JsonSerializer.Deserialize<MultilateralSettlementRequestV02>(json);

        Assert.Equal("MSG-001", (string)message.GroupHeader.MessageIdentification);
    }

    [Fact]
    public void TryDeserialize_ValidJson_ReturnsTrueWithMessage()
    {
        var json = Iso20022JsonSerializer.SerializeToString(ValidMessage());

        var success = Iso20022JsonSerializer.TryDeserialize<MultilateralSettlementRequestV02>(
            json,
            out var message,
            out var error
        );

        Assert.True(success);
        Assert.Null(error);
        Assert.NotNull(message);
    }

    [Fact]
    public void TryDeserialize_MalformedJson_ReturnsFalseWithJsonException()
    {
        var success = Iso20022JsonSerializer.TryDeserialize<MultilateralSettlementRequestV02>(
            "{ this is not valid json",
            out var message,
            out var error
        );

        Assert.False(success);
        Assert.Null(message);
        Assert.IsType<JsonException>(error);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void TryDeserialize_NullOrEmpty_ReturnsFalseWithJsonException(string? json)
    {
        var success = Iso20022JsonSerializer.TryDeserialize<MultilateralSettlementRequestV02>(
            json,
            out var message,
            out var error
        );

        Assert.False(success);
        Assert.Null(message);
        Assert.IsType<JsonException>(error);
    }
}

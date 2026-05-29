// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of instrument or product to which the exception/investigation refers, as published in an external investigation instrument code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_umAlME8pEe23pvrrPZbpBg")]
[Description(
    @"Specifies the type of instrument or product to which the exception/investigation refers, as published in an external investigation instrument code set.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalInvestigationInstrument1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalInvestigationInstrumentCode>))]
public enum ExternalInvestigationInstrumentCode
{
    /// <summary>
    /// Investigation is related to an ACH or mass payment.
    /// Encoded/decoded by serializers as &quot;ACHP&quot;.
    /// </summary>
    [EnumMember(Value = "ACHP")]
    [IsoId("__-YKPNYUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to an ACH or mass payment.")]
    ACHOrMass,

    /// <summary>
    /// Investigation is related to a card transaction.
    /// Encoded/decoded by serializers as &quot;CARD&quot;.
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("__-YKPtYUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a card transaction.")]
    Card,

    /// <summary>
    /// Investigation is related to a cheque.
    /// Encoded/decoded by serializers as &quot;CHQB&quot;.
    /// </summary>
    [EnumMember(Value = "CHQB")]
    [IsoId("__-YKOdYUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a cheque.")]
    Cheque,

    /// <summary>
    /// Investigation is related to a direct debit.
    /// Encoded/decoded by serializers as &quot;DDTP&quot;.
    /// </summary>
    [EnumMember(Value = "DDTP")]
    [IsoId("__-YKPdYUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a direct debit.")]
    DirectDebit,

    /// <summary>
    /// Investigation is related to a draft.
    /// Encoded/decoded by serializers as &quot;DRFT&quot;.
    /// </summary>
    [EnumMember(Value = "DRFT")]
    [IsoId("__-YKQdYUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a draft.")]
    Draft,

    /// <summary>
    /// Investigation is related to an instant credit transfer.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("__-YKOtYUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to an instant credit transfer.")]
    InstantCreditTransfer,

    /// <summary>
    /// Other underlying instrument.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("__-YKQ9YUEe68t8Cw380-tA")]
    [Description(@"Other underlying instrument.")]
    Other,

    /// <summary>
    /// Investigation is related to a request to pay.
    /// Encoded/decoded by serializers as &quot;SRTP&quot;.
    /// </summary>
    [EnumMember(Value = "SRTP")]
    [IsoId("__-YKQtYUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a request to pay.")]
    RequestToPay,

    /// <summary>
    /// Investigation is related to a statement entry.
    /// Encoded/decoded by serializers as &quot;STAT&quot;.
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("__-YKQNYUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a statement entry.")]
    StatementEntry,

    /// <summary>
    /// Investigation is related to a wire/high value payment.
    /// Encoded/decoded by serializers as &quot;URGP&quot;.
    /// </summary>
    [EnumMember(Value = "URGP")]
    [IsoId("__-YKP9YUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a wire/high value payment.")]
    HVPOrWire,

    /// <summary>
    /// Investigation is related to a cross border payment.
    /// Encoded/decoded by serializers as &quot;XBCT&quot;.
    /// </summary>
    [EnumMember(Value = "XBCT")]
    [IsoId("__-YKO9YUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a cross border payment.")]
    CrossBorderCreditTransfer,
}

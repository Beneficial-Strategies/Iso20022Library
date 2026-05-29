// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of instrument or product to which the investigation refers, as published in an external investigation instrument code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9cMNMFEUEe2YkcF60skG_A")]
[Description(
    @"Specifies the type of instrument or product to which the investigation refers, as published in an external investigation instrument code set.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalInvestigationInstrumentCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalInvestigationInstrument1Code>))]
public enum ExternalInvestigationInstrument1Code
{
    /// <summary>
    /// Investigation is related to an ACH or mass payment.
    /// Encoded/decoded by serializers as &quot;ACHP&quot;.
    /// </summary>
    [EnumMember(Value = "ACHP")]
    [IsoId("___Q7K9YUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to an ACH or mass payment.")]
    ACHOrMass = ExternalInvestigationInstrumentCode.ACHOrMass, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investigation is related to a card transaction.
    /// Encoded/decoded by serializers as &quot;CARD&quot;.
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("___Q7L9YUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a card transaction.")]
    Card = ExternalInvestigationInstrumentCode.Card, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investigation is related to a cheque.
    /// Encoded/decoded by serializers as &quot;CHQB&quot;.
    /// </summary>
    [EnumMember(Value = "CHQB")]
    [IsoId("___Q7JdYUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a cheque.")]
    Cheque = ExternalInvestigationInstrumentCode.Cheque, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investigation is related to a direct debit.
    /// Encoded/decoded by serializers as &quot;DDTP&quot;.
    /// </summary>
    [EnumMember(Value = "DDTP")]
    [IsoId("___Q7LdYUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a direct debit.")]
    DirectDebit = ExternalInvestigationInstrumentCode.DirectDebit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investigation is related to a draft.
    /// Encoded/decoded by serializers as &quot;DRFT&quot;.
    /// </summary>
    [EnumMember(Value = "DRFT")]
    [IsoId("___Q7NdYUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a draft.")]
    Draft = ExternalInvestigationInstrumentCode.Draft, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investigation is related to an instant credit transfer.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("___Q7J9YUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to an instant credit transfer.")]
    InstantCreditTransfer = ExternalInvestigationInstrumentCode.InstantCreditTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other underlying instrument.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("___Q7OdYUEe68t8Cw380-tA")]
    [Description(@"Other underlying instrument.")]
    Other = ExternalInvestigationInstrumentCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investigation is related to a request to pay.
    /// Encoded/decoded by serializers as &quot;SRTP&quot;.
    /// </summary>
    [EnumMember(Value = "SRTP")]
    [IsoId("___Q7N9YUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a request to pay.")]
    RequestToPay = ExternalInvestigationInstrumentCode.RequestToPay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investigation is related to a statement entry.
    /// Encoded/decoded by serializers as &quot;STAT&quot;.
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("___Q7M9YUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a statement entry.")]
    StatementEntry = ExternalInvestigationInstrumentCode.StatementEntry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investigation is related to a wire/high value payment.
    /// Encoded/decoded by serializers as &quot;URGP&quot;.
    /// </summary>
    [EnumMember(Value = "URGP")]
    [IsoId("___Q7MdYUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a wire/high value payment.")]
    HVPOrWire = ExternalInvestigationInstrumentCode.HVPOrWire, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investigation is related to a cross border payment.
    /// Encoded/decoded by serializers as &quot;XBCT&quot;.
    /// </summary>
    [EnumMember(Value = "XBCT")]
    [IsoId("___Q7KdYUEe68t8Cw380-tA")]
    [Description(@"Investigation is related to a cross border payment.")]
    CrossBorderCreditTransfer = ExternalInvestigationInstrumentCode.CrossBorderCreditTransfer, // same ordinal as derivation source for type conversions
}

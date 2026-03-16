// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Qualification of the information to sent to an output logical device, to display or print to the Cashier or the Customer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FbE-INwoEeioifFt1dhnJA")]
[Description(
    @"Qualification of the information to sent to an output logical device, to display or print to the Cashier or the Customer."
)]
[DerivedFrom(typeof(InformationQualifyCode))]
public enum InformationQualify1Code
{
    /// <summary>
    /// Input of the Cardholder POI interface which can be entered by the Cashier to assist the Customer.
    /// Encoded/decoded by serializers as &quot;CUSA&quot;.
    /// </summary>
    [EnumMember(Value = "CUSA")]
    [IsoId("_GjG9MdwoEeioifFt1dhnJA")]
    [Description(
        @"Input of the Cardholder POI interface which can be entered by the Cashier to assist the Customer."
    )]
    CustomerAssistance = InformationQualifyCode.CustomerAssistance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Standard display interface.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_GnixQdwoEeioifFt1dhnJA")]
    [Description(@"Standard display interface.")]
    Display = InformationQualifyCode.Display, // same ordinal as derivation source for type conversions

    /// <summary>
    /// When the POI System wants to print specific document (check, dynamic currency conversion ...). Used by the Sale System when the printer is not located on the Sale System.
    /// Encoded/decoded by serializers as &quot;DOCT&quot;.
    /// </summary>
    [EnumMember(Value = "DOCT")]
    [IsoId("_Gr_zcdwoEeioifFt1dhnJA")]
    [Description(
        @"When the POI System wants to print specific document (check, dynamic currency conversion ...). Used by the Sale System when the printer is not located on the Sale System."
    )]
    Document = InformationQualifyCode.Document, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The information is related to an error situation occurring on the message sender.
    /// Encoded/decoded by serializers as &quot;ERRO&quot;.
    /// </summary>
    [EnumMember(Value = "ERRO")]
    [IsoId("_Gwn0wdwoEeioifFt1dhnJA")]
    [Description(
        @"The information is related to an error situation occurring on the message sender."
    )]
    Error = InformationQualifyCode.Error, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Answer to a question or information to be entered by the Cashier or the Customer, at the request of the POI Terminal or the Sale Terminal.
    /// Encoded/decoded by serializers as &quot;INPT&quot;.
    /// </summary>
    [EnumMember(Value = "INPT")]
    [IsoId("_G05QwdwoEeioifFt1dhnJA")]
    [Description(
        @"Answer to a question or information to be entered by the Cashier or the Customer, at the request of the POI Terminal or the Sale Terminal."
    )]
    Input = InformationQualifyCode.Input, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Information displayed on the Cardholder POI interface, replicated on the Cashier interface.
    /// Encoded/decoded by serializers as &quot;POIR&quot;.
    /// </summary>
    [EnumMember(Value = "POIR")]
    [IsoId("_G5TPodwoEeioifFt1dhnJA")]
    [Description(
        @"Information displayed on the Cardholder POI interface, replicated on the Cashier interface."
    )]
    POIReplication = InformationQualifyCode.POIReplication, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Where you print the Payment receipt that could be located on the Sale System or in some cases a restricted Sale ticket on the POI Terminal.
    /// Encoded/decoded by serializers as &quot;RCPT&quot;.
    /// </summary>
    [EnumMember(Value = "RCPT")]
    [IsoId("_G-USgdwoEeioifFt1dhnJA")]
    [Description(
        @"Where you print the Payment receipt that could be located on the Sale System or in some cases a restricted Sale ticket on the POI Terminal."
    )]
    Receipt = InformationQualifyCode.Receipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Standard sound interface.
    /// Encoded/decoded by serializers as &quot;SOND&quot;.
    /// </summary>
    [EnumMember(Value = "SOND")]
    [IsoId("_HC7swdwoEeioifFt1dhnJA")]
    [Description(@"Standard sound interface.")]
    Sound = InformationQualifyCode.Sound, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The information is a new state on which the message sender is entering. For instance, during a payment, the POI could display to the Cashier that POI request an authorisation to the host acquirer.
    /// Encoded/decoded by serializers as &quot;STAT&quot;.
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_HGsLYdwoEeioifFt1dhnJA")]
    [Description(
        @"The information is a new state on which the message sender is entering. For instance, during a payment, the POI could display to the Cashier that POI request an authorisation to the host acquirer."
    )]
    Status = InformationQualifyCode.Status, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Coupons, voucher or special ticket generated by the POI or the Sale System and to be printed.
    /// Encoded/decoded by serializers as &quot;VCHR&quot;.
    /// </summary>
    [EnumMember(Value = "VCHR")]
    [IsoId("_HMHd8dwoEeioifFt1dhnJA")]
    [Description(
        @"Coupons, voucher or special ticket generated by the POI or the Sale System and to be printed."
    )]
    Voucher = InformationQualifyCode.Voucher, // same ordinal as derivation source for type conversions
}

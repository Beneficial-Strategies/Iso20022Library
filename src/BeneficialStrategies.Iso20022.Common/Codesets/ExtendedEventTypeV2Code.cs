// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_eJLcqHnhEeO2o_OAyvnbZw")]
[Description(@"Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type.")]
[Derivations(typeof(ExtendedEventType2Code),typeof(ExtendedEventType3Code),typeof(ExtendedEventType6Code),typeof(ExtendedEventType7Code))]
public enum ExtendedEventTypeV2Code
{
    /// <summary>
    /// Meeting of a company&apos;s share or bond holders to address resolutions put forth by the issuer. Note: this is information only event. Pending deprecation and migration to ISO Proxy Message suite.
    /// Encoded/decoded by serializers as &quot;MEET&quot;.
    /// </summary>
    [EnumMember(Value = "MEET")]
    [IsoId("_eJLcqXnhEeO2o_OAyvnbZw")]
    [Description(@"Meeting of a company's share or bond holders to address resolutions put forth by the issuer. Note: this is information only event. Pending deprecation and migration to ISO Proxy Message suite.")]
    Meeting,
    
    /// <summary>
    /// General information provided by the issuer that should not result in material changes to the security.
    /// Encoded/decoded by serializers as &quot;RPLA&quot;.
    /// </summary>
    [EnumMember(Value = "RPLA")]
    [IsoId("_eJLcqnnhEeO2o_OAyvnbZw")]
    [Description(@"General information provided by the issuer that should not result in material changes to the security.")]
    RightsPlanAdoption,
    
    /// <summary>
    /// Security, usually a form of a derivative, for which the agent or issuer has decided to terminate the derivative based on a change to the underlying security(ies) or a change in strategy. Distinguishes from Mandatory Exchange, Exchange Offer event types mapped to the same ISO event type code.
    /// Encoded/decoded by serializers as &quot;TMTN&quot;.
    /// </summary>
    [EnumMember(Value = "TMTN")]
    [IsoId("_eJLcrHnhEeO2o_OAyvnbZw")]
    [Description(@"Security, usually a form of a derivative, for which the agent or issuer has decided to terminate the derivative based on a change to the underlying security(ies) or a change in strategy. Distinguishes from Mandatory Exchange, Exchange Offer event types mapped to the same ISO event type code.")]
    Termination,
    
    /// <summary>
    /// Security holders are issued additional securities, free of payment, from the issuer in proportion to their holdings. A bonus issue is typically represented by shares or warrants. Nominal value does not change. The security holder may be offered choice of entitlement. Distinguishes from Rights Subscription, Sale Of Rights event types mapped to the same ISO event type code.
    /// Encoded/decoded by serializers as &quot;BRIS&quot;.
    /// </summary>
    [EnumMember(Value = "BRIS")]
    [IsoId("_eJLcrnnhEeO2o_OAyvnbZw")]
    [Description(@"Security holders are issued additional securities, free of payment, from the issuer in proportion to their holdings. A bonus issue is typically represented by shares or warrants. Nominal value does not change. The security holder may be offered choice of entitlement. Distinguishes from Rights Subscription, Sale Of Rights event types mapped to the same ISO event type code.")]
    BonusRightsIssue,
    
    /// <summary>
    /// Exercise of a privilege by the issuer to repay, in full, any debt security prior to maturity when the issuer deposits assets in trust. This irrevocably restricts their use to satisfaction of the debt. Distinguishes from &quot;partial defeasance&quot;, &quot;partial prerefunding&quot; event types mapped to the same ISO event type code.
    /// Encoded/decoded by serializers as &quot;FLPR&quot;.
    /// </summary>
    [EnumMember(Value = "FLPR")]
    [IsoId("_eJLcq3nhEeO2o_OAyvnbZw")]
    [Description(@"Exercise of a privilege by the issuer to repay, in full, any debt security prior to maturity when the issuer deposits assets in trust. This irrevocably restricts their use to satisfaction of the debt. Distinguishes from ""partial defeasance"", ""partial prerefunding"" event types mapped to the same ISO event type code.")]
    FullPrerefunding,
    
    /// <summary>
    /// Issuer sets aside funds in escrow to guarantee payment for the portion of the security on maturity date. Defeased and Non-defeased cusips are issued respectively for the defeased and non-defeased portions.
    /// Encoded/decoded by serializers as &quot;PDEF&quot;.
    /// </summary>
    [EnumMember(Value = "PDEF")]
    [IsoId("_eJLcr3nhEeO2o_OAyvnbZw")]
    [Description(@"Issuer sets aside funds in escrow to guarantee payment for the portion of the security on maturity date. Defeased and Non-defeased cusips are issued respectively for the defeased and non-defeased portions.")]
    PartialDefeasance,
    
    /// <summary>
    /// Issuer sets aside funds in escrow to guarantee payment for the portion of the security prior to maturity date. Refunded and Non-Refunded cusips are issued respectively for the refunded and non-refunded portions.
    /// Encoded/decoded by serializers as &quot;PPRE&quot;.
    /// </summary>
    [EnumMember(Value = "PPRE")]
    [IsoId("_eJLcrXnhEeO2o_OAyvnbZw")]
    [Description(@"Issuer sets aside funds in escrow to guarantee payment for the portion of the security prior to maturity date. Refunded and Non-Refunded cusips are issued respectively for the refunded and non-refunded portions.")]
    PartialPrerefunding,
    
    /// <summary>
    /// The mandatory exchange of a portion of bonds where the exchanged securities are usually remarketed. The issuer may offer holders the right to retain instead of exchanging their securities.
    /// Encoded/decoded by serializers as &quot;PPUT&quot;.
    /// </summary>
    [EnumMember(Value = "PPUT")]
    [IsoId("_yCaQ4HnhEeO2o_OAyvnbZw")]
    [Description(@"The mandatory exchange of a portion of bonds where the exchanged securities are usually remarketed. The issuer may offer holders the right to retain instead of exchanging their securities.")]
    PartialMandatoryPut,
    
    /// <summary>
    /// Feature of a security that allows an issuer to make a payment to the security holder. This event will be used for securities subject to redemptions other than those categorised as full and partial calls (for example early Certificate of Deposit redemptions).
    /// Encoded/decoded by serializers as &quot;CDRD&quot;.
    /// </summary>
    [EnumMember(Value = "CDRD")]
    [IsoId("_2BX80JEREeajS_7NioJdVA")]
    [Description(@"Feature of a security that allows an issuer to make a payment to the security holder. This event will be used for securities subject to redemptions other than those categorised as full and partial calls (for example early Certificate of Deposit redemptions).")]
    CertificateOfDepositEarlyRedemption,
    
    /// <summary>
    /// Final distribution of principal due on a security, typically Collateralised Mortgage Obligations.
    /// Encoded/decoded by serializers as &quot;FPAY&quot;.
    /// </summary>
    [EnumMember(Value = "FPAY")]
    [IsoId("_UtN_EJESEeajS_7NioJdVA")]
    [Description(@"Final distribution of principal due on a security, typically Collateralised Mortgage Obligations.")]
    FinalPaydown,
    
    /// <summary>
    /// Event is a redemption of warrant.
    /// Encoded/decoded by serializers as &quot;REDW&quot;.
    /// </summary>
    [EnumMember(Value = "REDW")]
    [IsoId("_kw2mgL_pEeeb2ZBoAlSG1Q")]
    [Description(@"Event is a redemption of warrant.")]
    RedemptionOfWarrant,
    
}

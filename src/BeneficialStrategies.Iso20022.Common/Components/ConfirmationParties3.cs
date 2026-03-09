// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parties used for acting parties that apply either to the whole message or to individual sides.
/// </summary>
[IsoId("_AdSOYNokEeC60axPepSq7g_-2040835565")]
[DisplayName("Confirmation Parties")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ConfirmationParties3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ConfirmationParties3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ConfirmationParties3( ConfirmationPartyDetails4 reqAffirmingParty )
    {
        AffirmingParty = reqAffirmingParty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party (buyer or seller) that positively affirms the details of a previously agreed security trade confirmation.
    /// </summary>
    [IsoId("_AdSOYdokEeC60axPepSq7g_-430407444")]
    [DisplayName("Affirming Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AffrmgPty")]
    #endif
    [IsoXmlTag("AffrmgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ConfirmationPartyDetails4 AffirmingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ConfirmationPartyDetails4 AffirmingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails4 AffirmingParty { get; init; } 
    #else
    public ConfirmationPartyDetails4 AffirmingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_AdSOYtokEeC60axPepSq7g_-1862716893")]
    [DisplayName("Buyer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Buyr")]
    #endif
    [IsoXmlTag("Buyr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationPartyDetails2? Buyer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails2? Buyer { get; init; } 
    #else
    public ConfirmationPartyDetails2? Buyer { get; set; } 
    #endif
    
    /// <summary>
    /// Party that has applied, met specific requirements, and received a monetary or securities loan from a lender. The party initiating the request signs a promissory note agreeing to pay the lien holder back during a specified timeframe for the entire loan amount plus any additional fees. The borrower is legally responsible for repayment of the loan and is subject to any penalties for not repaying the loan back based on the lending terms agreed upon.
    /// </summary>
    [IsoId("_AdSOY9okEeC60axPepSq7g_-353765411")]
    [DisplayName("Borrower")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Brrwr")]
    #endif
    [IsoXmlTag("Brrwr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationPartyDetails2? Borrower { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails2? Borrower { get; init; } 
    #else
    public ConfirmationPartyDetails2? Borrower { get; set; } 
    #endif
    
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_AdSOZNokEeC60axPepSq7g_1257059378")]
    [DisplayName("Seller")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sellr")]
    #endif
    [IsoXmlTag("Sellr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationPartyDetails2? Seller { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails2? Seller { get; init; } 
    #else
    public ConfirmationPartyDetails2? Seller { get; set; } 
    #endif
    
    /// <summary>
    /// A private, public or institutional entity which makes funds available to others to borrow.
    /// </summary>
    [IsoId("_AdSOZdokEeC60axPepSq7g_1291502024")]
    [DisplayName("Lender")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lndr")]
    #endif
    [IsoXmlTag("Lndr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationPartyDetails2? Lender { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails2? Lender { get; init; } 
    #else
    public ConfirmationPartyDetails2? Lender { get; set; } 
    #endif
    
    /// <summary>
    /// Party involved in a legal proceeding, agreement, or other transaction.
    /// </summary>
    [IsoId("_AdSOZtokEeC60axPepSq7g_-1364420240")]
    [DisplayName("Trade Beneficiary Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradBnfcryPty")]
    #endif
    [IsoXmlTag("TradBnfcryPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConfirmationPartyDetails3? TradeBeneficiaryParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationPartyDetails3? TradeBeneficiaryParty { get; init; } 
    #else
    public ConfirmationPartyDetails3? TradeBeneficiaryParty { get; set; } 
    #endif
    
    
    #nullable disable
    
}

// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria which are used to search for standing orders defined within the system.
/// </summary>
[IsoId("_jE-P6ZlPEee-Zps0fZQaFQ")]
[DisplayName("Standing Order Search Criteria")]
public partial record StandingOrderSearchCriteria2
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the key fields or business attributes defined within the system must be returned.
    /// </summary>
    [IsoId("_jNAKgZlPEee-Zps0fZQaFQ")]
    [DisplayName("Key Attributes Indicator")]
    [IsoXmlTag("KeyAttrbtsInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? KeyAttributesIndicator { get; init; } 
    
    /// <summary>
    /// Unique identification to unambiguously identify the standing order used to initiate the liquidity transfer.
    /// </summary>
    [IsoId("_jNAKg5lPEee-Zps0fZQaFQ")]
    [DisplayName("Standing Order Identification")]
    [IsoXmlTag("StgOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? StandingOrderIdentification { get; init; } 
    
    /// <summary>
    /// Type of the standing order.
    /// </summary>
    [IsoId("_jNAKhZlPEee-Zps0fZQaFQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public StandingOrderType1Choice_? Type { get; init; } 
    
    /// <summary>
    /// Liquidity transfer origin or destination account within the pool of accounts under management of the requestor.
    /// </summary>
    [IsoId("_jNAKh5lPEee-Zps0fZQaFQ")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public CashAccount24? Account { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification for a standing order, as assigned by the account servicer or the account owner.
    /// </summary>
    [IsoId("_jNAKiZlPEee-Zps0fZQaFQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; } 
    
    /// <summary>
    /// Dates during which the standing order is in effect.
    /// </summary>
    [IsoId("_jNAKi5lPEee-Zps0fZQaFQ")]
    [DisplayName("Validity Period")]
    [IsoXmlTag("VldtyPrd")]
    public DatePeriod2Choice_? ValidityPeriod { get; init; } 
    
    /// <summary>
    /// Specifies if the account is debited or credited by the standing order.
    /// </summary>
    [IsoId("_jNAKjZlPEee-Zps0fZQaFQ")]
    [DisplayName("System Member")]
    [IsoXmlTag("SysMmb")]
    public BranchAndFinancialInstitutionIdentification5? SystemMember { get; init; } 
    
    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [IsoId("_jNAKj5lPEee-Zps0fZQaFQ")]
    [DisplayName("Responsible Party")]
    [IsoXmlTag("RspnsblPty")]
    public BranchAndFinancialInstitutionIdentification5? ResponsibleParty { get; init; } 
    
    /// <summary>
    /// Liquidity transfer origin or destination account within the pool of accounts under management of the requestor.
    /// </summary>
    [IsoId("_jNAKkZlPEee-Zps0fZQaFQ")]
    [DisplayName("Associated Pool Account")]
    [IsoXmlTag("AssoctdPoolAcct")]
    public AccountIdentification4Choice_? AssociatedPoolAccount { get; init; } 
    
    /// <summary>
    /// Unique identification to unambiguously identify the link set in which the standing order is defined. The link set is a collection of standing order defined in a specific sequence.
    /// </summary>
    [IsoId("_jNAKk5lPEee-Zps0fZQaFQ")]
    [DisplayName("Link Set Identification")]
    [IsoXmlTag("LkSetId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? LinkSetIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification to unambiguously identify liquidity transfer standing order within the link set.
    /// </summary>
    [IsoId("_jNAKlZlPEee-Zps0fZQaFQ")]
    [DisplayName("Link Set Order Identification")]
    [IsoXmlTag("LkSetOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? LinkSetOrderIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the sequence in which the system will execute the liquidity transfers standing order within the link set when additional liquidity is required.
    /// </summary>
    [IsoId("_jNAKl5lPEee-Zps0fZQaFQ")]
    [DisplayName("Link Set Order Sequence")]
    [IsoXmlTag("LkSetOrdrSeq")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? LinkSetOrderSequence { get; init; } 
    
    /// <summary>
    /// Indicates whether the query shall return all liquidity transfer standing orders defined as zero sweeping orders.
    /// When the indicator is set to true, the liquidity transfer standing order will transfer all amount of money out of the account so the resulting balance is zero.
    /// </summary>
    [IsoId("_jNAKmZlPEee-Zps0fZQaFQ")]
    [DisplayName("Zero Sweep Indicator")]
    [IsoXmlTag("ZeroSweepInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ZeroSweepIndicator { get; init; } 
    
    
    #nullable disable
    
}

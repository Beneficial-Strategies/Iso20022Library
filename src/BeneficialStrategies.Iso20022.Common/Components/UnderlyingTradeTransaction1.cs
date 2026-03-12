// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a transaction.
/// </summary>
[IsoId("_96PRVnltEeG7BsjMvd1mEw_-533314240")]
[DisplayName("Underlying Trade Transaction")]
public partial record UnderlyingTradeTransaction1
{
    #nullable enable
    
    /// <summary>
    /// Type of underlying transaction such as a tender, order, contract.
    /// </summary>
    [IsoId("_96PRV3ltEeG7BsjMvd1mEw_145675419")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required UnderlyingTradeTransactionType1Choice_ Type { get; init; } 
    
    /// <summary>
    /// Identification of the underlying transaction.
    /// </summary>
    [IsoId("_96PRWHltEeG7BsjMvd1mEw_-1698193570")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; } 
    
    /// <summary>
    /// Date the underlying transaction was issued or awarded.
    /// </summary>
    [IsoId("_96PRWXltEeG7BsjMvd1mEw_-1244106301")]
    [DisplayName("Transaction Date")]
    [IsoXmlTag("TxDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TransactionDate { get; init; } 
    
    /// <summary>
    /// Date the tender closes.
    /// </summary>
    [IsoId("_96PRWnltEeG7BsjMvd1mEw_211943685")]
    [DisplayName("Tender Closing Date")]
    [IsoXmlTag("TndrClsgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TenderClosingDate { get; init; } 
    
    /// <summary>
    /// Amount of the underlying transaction.
    /// </summary>
    [IsoId("_96YbQHltEeG7BsjMvd1mEw_-1461796889")]
    [DisplayName("Transaction Amount")]
    [IsoXmlTag("TxAmt")]
    public ActiveCurrencyAndAmount? TransactionAmount { get; init; } 
    
    /// <summary>
    /// Percentage of the underlying contract covered by the undertaking.
    /// </summary>
    [IsoId("_96YbQXltEeG7BsjMvd1mEw_-304059961")]
    [DisplayName("Contract Amount Percentage")]
    [IsoXmlTag("CtrctAmtPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? ContractAmountPercentage { get; init; } 
    
    /// <summary>
    /// Additional information related to the underlying transaction.
    /// </summary>
    [IsoId("_96YbQnltEeG7BsjMvd1mEw_-826765043")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}

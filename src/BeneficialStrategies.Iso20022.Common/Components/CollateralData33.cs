// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the collateral used in the transaction.
/// </summary>
[IsoId("_QMn0QcguEeuGrNSsxk3B0A")]
[DisplayName("Collateral Data")]
public partial record CollateralData33
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the collateral has been provided for a net exposure, rather than for a single transaction.
    /// </summary>
    [IsoId("_QOdAQ8guEeuGrNSsxk3B0A")]
    [DisplayName("Net Exposure Collateralisation Indicator")]
    [IsoXmlTag("NetXpsrCollstnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? NetExposureCollateralisationIndicator { get; init; } 
    
    /// <summary>
    /// Indication of the type of collateral component.
    /// </summary>
    [IsoId("_QOdARcguEeuGrNSsxk3B0A")]
    [DisplayName("Component Type")]
    [IsoXmlTag("CmpntTp")]
    public CollateralType6Code? ComponentType { get; init; } 
    
    /// <summary>
    /// Currency of unit of cash collateral component.
    /// </summary>
    [IsoId("_QOdAR8guEeuGrNSsxk3B0A")]
    [DisplayName("Cash Collateral Currency")]
    [IsoXmlTag("CshCollCcy")]
    public ActiveOrHistoricCurrencyCode? CashCollateralCurrency { get; init; } 
    
    /// <summary>
    /// Currency of price of unit of collateral component.
    /// </summary>
    [IsoId("_QOdAScguEeuGrNSsxk3B0A")]
    [DisplayName("Price Currency")]
    [IsoXmlTag("PricCcy")]
    public ActiveOrHistoricCurrencyCode? PriceCurrency { get; init; } 
    
    /// <summary>
    /// Code that classifies the risk of the security.
    /// </summary>
    [IsoId("_QOdAS8guEeuGrNSsxk3B0A")]
    [DisplayName("Quality")]
    [IsoXmlTag("Qlty")]
    public CollateralQualityType1Code? Quality { get; init; } 
    
    /// <summary>
    /// Maturity of the security.
    /// </summary>
    [IsoId("_QOdATcguEeuGrNSsxk3B0A")]
    [DisplayName("Maturity")]
    [IsoXmlTag("Mtrty")]
    public ContractTerm6Choice_? Maturity { get; init; } 
    
    /// <summary>
    /// Jurisdiction of the issuer of the security used as collateral. 
    /// </summary>
    [IsoId("_QOdAT8guEeuGrNSsxk3B0A")]
    [DisplayName("Issuer Jurisdiction")]
    [IsoXmlTag("IssrJursdctn")]
    public IssuerJurisdiction1Choice_? IssuerJurisdiction { get; init; } 
    
    /// <summary>
    /// Classification of the type of the security.
    /// </summary>
    [IsoId("_QOdAUcguEeuGrNSsxk3B0A")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public SecuritiesLendingType3Choice_? Type { get; init; } 
    
    /// <summary>
    /// Trade Repository to which the other counterparty reported.
    /// </summary>
    [IsoId("_QOdAU8guEeuGrNSsxk3B0A")]
    [DisplayName("Trade Repository")]
    [IsoXmlTag("TradRpstry")]
    public OrganisationIdentification15Choice_? TradeRepository { get; init; } 
    
    /// <summary>
    /// List of possible values for TRs reconciliation purposes.
    /// </summary>
    [IsoId("_QOdAVcguEeuGrNSsxk3B0A")]
    [DisplayName("Reconciliation Flag")]
    [IsoXmlTag("RcncltnFlg")]
    public ReconciliationFlag2? ReconciliationFlag { get; init; } 
    
    /// <summary>
    /// Provides details on the type and amount of the cash reinvestment in a given currency.
    /// </summary>
    [IsoId("_QOdAV8guEeuGrNSsxk3B0A")]
    [DisplayName("Reinvested Cash")]
    [IsoXmlTag("RinvstdCsh")]
    public ReinvestedCashTypeAndAmount2? ReinvestedCash { get; init; } 
    
    
    #nullable disable
    
}

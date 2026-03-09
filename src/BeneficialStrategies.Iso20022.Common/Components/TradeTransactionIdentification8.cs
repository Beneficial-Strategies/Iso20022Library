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
/// Provides details on transaction and conducting counterparty.
/// </summary>
[IsoId("_Cn2qga7MEemZxoEFHjN-AQ")]
[DisplayName("Trade Transaction Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeTransactionIdentification8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeTransactionIdentification8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeTransactionIdentification8( OrganisationIdentification9Choice_ reqReportingCounterparty,OrganisationIdentification9Choice_ reqOtherCounterparty,System.String reqCollateralPortfolioIdentification )
    {
        ReportingCounterparty = reqReportingCounterparty;
        OtherCounterparty = reqOtherCounterparty;
        CollateralPortfolioIdentification = reqCollateralPortfolioIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique code identifying the reporting counterparty.
    /// </summary>
    [IsoId("_CsUTwa7MEemZxoEFHjN-AQ")]
    [DisplayName("Reporting Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgCtrPty")]
    #endif
    [IsoXmlTag("RptgCtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrganisationIdentification9Choice_ ReportingCounterparty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrganisationIdentification9Choice_ ReportingCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification9Choice_ ReportingCounterparty { get; init; } 
    #else
    public OrganisationIdentification9Choice_ ReportingCounterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Unique code identifying the entity with which the reporting counterparty concluded the transaction.
    /// </summary>
    [IsoId("_CsUTw67MEemZxoEFHjN-AQ")]
    [DisplayName("Other Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrCtrPty")]
    #endif
    [IsoXmlTag("OthrCtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrganisationIdentification9Choice_ OtherCounterparty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrganisationIdentification9Choice_ OtherCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification9Choice_ OtherCounterparty { get; init; } 
    #else
    public OrganisationIdentification9Choice_ OtherCounterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification of the collateral portfolio.
    /// </summary>
    [IsoId("_URsPAa7MEemZxoEFHjN-AQ")]
    [DisplayName("Collateral Portfolio Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollPrtflId")]
    #endif
    [IsoXmlTag("CollPrtflId")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax52Text CollateralPortfolioIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CollateralPortfolioIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CollateralPortfolioIdentification { get; init; } 
    #else
    public System.String CollateralPortfolioIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}

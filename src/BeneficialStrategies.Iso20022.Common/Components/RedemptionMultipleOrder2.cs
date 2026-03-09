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
/// Instruction from an investor to sell investment fund units back to the fund.
/// </summary>
[IsoId("_VddsSdp-Ed-ak6NoX_4Aeg_-438010863")]
[DisplayName("Redemption Multiple Order")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RedemptionMultipleOrder2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RedemptionMultipleOrder2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RedemptionMultipleOrder2( InvestmentAccount13 reqInvestmentAccountDetails )
    {
        InvestmentAccountDetails = reqInvestmentAccountDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Market in which the advised trade transaction was executed.
    /// </summary>
    [IsoId("_VddsStp-Ed-ak6NoX_4Aeg_-438010425")]
    [DisplayName("Place Of Trade")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfTrad")]
    #endif
    [IsoXmlTag("PlcOfTrad")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? PlaceOfTrade { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? PlaceOfTrade { get; init; } 
    #else
    public string? PlaceOfTrade { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the order was placed by the investor.
    /// </summary>
    [IsoId("_VddsS9p-Ed-ak6NoX_4Aeg_1097157709")]
    [DisplayName("Order Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrDtTm")]
    #endif
    [IsoXmlTag("OrdrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? OrderDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? OrderDateTime { get; init; } 
    #else
    public System.DateTime? OrderDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the order expires.
    /// </summary>
    [IsoId("_VddsTNp-Ed-ak6NoX_4Aeg_-2087712576")]
    [DisplayName("Expiry Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpryDtTm")]
    #endif
    [IsoXmlTag("XpryDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? ExpiryDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? ExpiryDateTime { get; init; } 
    #else
    public System.DateTime? ExpiryDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Cancellation right of an investor with respect to an investment fund order.
    /// </summary>
    [IsoId("_VddsTdp-Ed-ak6NoX_4Aeg_-438010459")]
    [DisplayName("Cancellation Right")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRght")]
    #endif
    [IsoXmlTag("CxlRght")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CancellationRight1? CancellationRight { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationRight1? CancellationRight { get; init; } 
    #else
    public CancellationRight1? CancellationRight { get; set; } 
    #endif
    
    /// <summary>
    /// Account impacted by an investment fund order.
    /// </summary>
    [IsoId("_VddsTtp-Ed-ak6NoX_4Aeg_-438009897")]
    [DisplayName("Investment Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcctDtls")]
    #endif
    [IsoXmlTag("InvstmtAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentAccount13 InvestmentAccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestmentAccount13 InvestmentAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount13 InvestmentAccountDetails { get; init; } 
    #else
    public InvestmentAccount13 InvestmentAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the investor.
    /// </summary>
    [IsoId("_VddsT9p-Ed-ak6NoX_4Aeg_110663030")]
    [DisplayName("Beneficiary Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnfcryDtls")]
    #endif
    [IsoXmlTag("BnfcryDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndividualPerson2? BeneficiaryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndividualPerson2? BeneficiaryDetails { get; init; } 
    #else
    public IndividualPerson2? BeneficiaryDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Instruction from an investor to sell investment fund units back to the fund.
    /// </summary>
    [IsoId("_VdndQNp-Ed-ak6NoX_4Aeg_-438009880")]
    [DisplayName("Individual Order Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndvOrdrDtls")]
    #endif
    [IsoXmlTag("IndvOrdrDtls")]
    public ValueList<RedemptionOrder4> IndividualOrderDetails { get; init; } = new ValueList<RedemptionOrder4>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _VdndQNp-Ed-ak6NoX_4Aeg_-438009880
    
    /// <summary>
    /// Payment transaction resulting from the investment fund order execution.
    /// </summary>
    [IsoId("_VdndQdp-Ed-ak6NoX_4Aeg_-438009837")]
    [DisplayName("Bulk Cash Settlement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlkCshSttlmDtls")]
    #endif
    [IsoXmlTag("BlkCshSttlmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTransaction15? BulkCashSettlementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTransaction15? BulkCashSettlementDetails { get; init; } 
    #else
    public PaymentTransaction15? BulkCashSettlementDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}

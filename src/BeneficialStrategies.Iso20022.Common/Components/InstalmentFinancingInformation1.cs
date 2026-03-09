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
/// Information about result of a single instalment (financed or not) within an invoice.
/// </summary>
[IsoId("_PyxaU9p-Ed-ak6NoX_4Aeg_1394536846")]
[DisplayName("Instalment Financing Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InstalmentFinancingInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InstalmentFinancingInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InstalmentFinancingInformation1( System.String reqInstalmentSequenceIdentification,ActiveCurrencyAndAmount reqInstalmentTotalAmount,FinancingResult1 reqInstalmentFinancingResult )
    {
        InstalmentSequenceIdentification = reqInstalmentSequenceIdentification;
        InstalmentTotalAmount = reqInstalmentTotalAmount;
        InstalmentFinancingResult = reqInstalmentFinancingResult;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Progressive number of the single instalment related to an invoice.
    /// </summary>
    [IsoId("_PyxaVNp-Ed-ak6NoX_4Aeg_254515146")]
    [DisplayName("Instalment Sequence Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstlmtSeqId")]
    #endif
    [IsoXmlTag("InstlmtSeqId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax70Text InstalmentSequenceIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String InstalmentSequenceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String InstalmentSequenceIdentification { get; init; } 
    #else
    public System.String InstalmentSequenceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("_PyxaVdp-Ed-ak6NoX_4Aeg_310847975")]
    [DisplayName("Instalment Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstlmtTtlAmt")]
    #endif
    [IsoXmlTag("InstlmtTtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount InstalmentTotalAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount InstalmentTotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount InstalmentTotalAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount InstalmentTotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the financing result of one instalment.
    /// </summary>
    [IsoId("_PyxaVtp-Ed-ak6NoX_4Aeg_721361782")]
    [DisplayName("Instalment Financing Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstlmtFincgRslt")]
    #endif
    [IsoXmlTag("InstlmtFincgRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancingResult1 InstalmentFinancingResult { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancingResult1 InstalmentFinancingResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancingResult1 InstalmentFinancingResult { get; init; } 
    #else
    public FinancingResult1 InstalmentFinancingResult { get; set; } 
    #endif
    
    
    #nullable disable
    
}

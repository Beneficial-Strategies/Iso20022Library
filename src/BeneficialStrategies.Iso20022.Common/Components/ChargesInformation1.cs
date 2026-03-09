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
/// Information on the charges related to the payment transaction.
/// </summary>
[IsoId("_RtjsAtp-Ed-ak6NoX_4Aeg_-450206740")]
[DisplayName("Charges Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ChargesInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ChargesInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ChargesInformation1( CurrencyAndAmount reqChargesAmount,BranchAndFinancialInstitutionIdentification3 reqChargesParty )
    {
        ChargesAmount = reqChargesAmount;
        ChargesParty = reqChargesParty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Transaction charges to be paid by the charge bearer.
    /// </summary>
    [IsoId("_RtjsA9p-Ed-ak6NoX_4Aeg_1765318183")]
    [DisplayName("Charges Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsAmt")]
    #endif
    [IsoXmlTag("ChrgsAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount ChargesAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount ChargesAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount ChargesAmount { get; init; } 
    #else
    public CurrencyAndAmount ChargesAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Party that takes the transaction charges or to which the transaction charges are due.
    /// </summary>
    [IsoId("_RtjsBNp-Ed-ak6NoX_4Aeg_1407518272")]
    [DisplayName("Charges Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsPty")]
    #endif
    [IsoXmlTag("ChrgsPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification3 ChargesParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification3 ChargesParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification3 ChargesParty { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification3 ChargesParty { get; set; } 
    #endif
    
    
    #nullable disable
    
}

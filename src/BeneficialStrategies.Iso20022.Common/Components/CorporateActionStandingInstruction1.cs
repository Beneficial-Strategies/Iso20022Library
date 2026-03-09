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
/// Provides information about the standing instruction.
/// </summary>
[IsoId("_UJbRidp-Ed-ak6NoX_4Aeg_852863952")]
[DisplayName("Corporate Action Standing Instruction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionStandingInstruction1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionStandingInstruction1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionStandingInstruction1( StandingInstructionGrossNet1Code reqNetOrGross,CashAccount17 reqCashDistributionDetails,SecuritiesAccount6 reqSecuritiesDistributionDetails )
    {
        NetOrGross = reqNetOrGross;
        CashDistributionDetails = reqCashDistributionDetails;
        SecuritiesDistributionDetails = reqSecuritiesDistributionDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies whether the account Holders want their income to be paid net or gross of income tax (default is gross).
    /// </summary>
    [IsoId("_UJbRitp-Ed-ak6NoX_4Aeg_1113626304")]
    [DisplayName("Net Or Gross")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetOrGrss")]
    #endif
    [IsoXmlTag("NetOrGrss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StandingInstructionGrossNet1Code NetOrGross { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StandingInstructionGrossNet1Code NetOrGross { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StandingInstructionGrossNet1Code NetOrGross { get; init; } 
    #else
    public StandingInstructionGrossNet1Code NetOrGross { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the cash distribution standing instruction.
    /// </summary>
    [IsoId("_UJbRi9p-Ed-ak6NoX_4Aeg_-650296854")]
    [DisplayName("Cash Distribution Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshDstrbtnDtls")]
    #endif
    [IsoXmlTag("CshDstrbtnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAccount17 CashDistributionDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashAccount17 CashDistributionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount17 CashDistributionDetails { get; init; } 
    #else
    public CashAccount17 CashDistributionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the securities distribution standing instruction.
    /// </summary>
    [IsoId("_UJbRjNp-Ed-ak6NoX_4Aeg_949052482")]
    [DisplayName("Securities Distribution Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesDstrbtnDtls")]
    #endif
    [IsoXmlTag("SctiesDstrbtnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesAccount6 SecuritiesDistributionDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesAccount6 SecuritiesDistributionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount6 SecuritiesDistributionDetails { get; init; } 
    #else
    public SecuritiesAccount6 SecuritiesDistributionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the standing instruction.
    /// </summary>
    [IsoId("_UJkbcNp-Ed-ak6NoX_4Aeg_1012038453")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}

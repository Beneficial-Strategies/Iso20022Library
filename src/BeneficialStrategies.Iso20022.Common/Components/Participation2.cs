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
/// Specifies the level of participation to a shareholders meeting.
/// </summary>
[IsoId("_Tj3tYdp-Ed-ak6NoX_4Aeg_48636635")]
[DisplayName("Participation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Participation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of rights admitted to the vote.
    /// </summary>
    [IsoId("_Tj3tYtp-Ed-ak6NoX_4Aeg_48636637")]
    [DisplayName("Total Number Of Voting Rights")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfVtngRghts")]
    #endif
    [IsoXmlTag("TtlNbOfVtngRghts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? TotalNumberOfVotingRights { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TotalNumberOfVotingRights { get; init; } 
    #else
    public System.UInt64? TotalNumberOfVotingRights { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of rights participating to the vote versus total voting rights.
    /// </summary>
    [IsoId("_Tj3tY9p-Ed-ak6NoX_4Aeg_48636713")]
    [DisplayName("Percentage Of Voting Rights")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PctgOfVtngRghts")]
    #endif
    [IsoXmlTag("PctgOfVtngRghts")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? PercentageOfVotingRights { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? PercentageOfVotingRights { get; init; } 
    #else
    public System.Decimal? PercentageOfVotingRights { get; set; } 
    #endif
    
    /// <summary>
    /// Number of securities admitted to the vote, expressed as an amount and a currency.
    /// </summary>
    [IsoId("_Tj3tZNp-Ed-ak6NoX_4Aeg_48636678")]
    [DisplayName("Total Number Of Securities Outstanding")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfSctiesOutsdng")]
    #endif
    [IsoXmlTag("TtlNbOfSctiesOutsdng")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? TotalNumberOfSecuritiesOutstanding { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? TotalNumberOfSecuritiesOutstanding { get; init; } 
    #else
    public CurrencyAndAmount? TotalNumberOfSecuritiesOutstanding { get; set; } 
    #endif
    
    /// <summary>
    /// Date of calculation of the total number of oustanding securities.
    /// </summary>
    [IsoId("_Tj3tZdp-Ed-ak6NoX_4Aeg_48636730")]
    [DisplayName("Calculation Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClctnDt")]
    #endif
    [IsoXmlTag("ClctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? CalculationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? CalculationDate { get; init; } 
    #else
    public System.DateOnly? CalculationDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}

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
/// Specifies the debit instrument.
/// </summary>
[IsoId("_PCM3wX5gEea2k7EBUopqxw")]
[DisplayName("Debt Instrument")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DebtInstrument5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DebtInstrument5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DebtInstrument5( BondType1Code reqType,System.DateOnly reqIssuanceDate )
    {
        Type = reqType;
        IssuanceDate = reqIssuanceDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of bond type.
    /// </summary>
    [IsoId("_PO2MoX5gEea2k7EBUopqxw")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BondType1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BondType1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BondType1Code Type { get; init; } 
    #else
    public BondType1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which a bond is issued and begins to accrue interest.
    /// </summary>
    [IsoId("_PO2Mo35gEea2k7EBUopqxw")]
    [DisplayName("Issuance Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssncDt")]
    #endif
    [IsoXmlTag("IssncDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate IssuanceDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly IssuanceDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly IssuanceDate { get; init; } 
    #else
    public System.DateOnly IssuanceDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}

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
/// Operational construct used to record the set of positions whose margin requirements is calculated on a gross basis.
/// </summary>
[IsoId("_vzEGEHYDEee_qcLXasnA4g")]
[DisplayName("Margin Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MarginAccount1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MarginAccount1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MarginAccount1( PartyIdentification118Choice_ reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier of the margin account.
    /// </summary>
    [IsoId("_1kQBkHYDEee_qcLXasnA4g")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification118Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification118Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification118Choice_ Identification { get; init; } 
    #else
    public PartyIdentification118Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Operational construct used to record a position in a set of financial instruments, often linked by a common set of characteristics, ownership or trading strategy.
    /// </summary>
    [IsoId("_5-_HgHYDEee_qcLXasnA4g")]
    [DisplayName("Position Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PosAcct")]
    #endif
    [IsoXmlTag("PosAcct")]
    public ValueList<PositionAccount1> PositionAccount { get; init; } = new ValueList<PositionAccount1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _5-_HgHYDEee_qcLXasnA4g
    
    
    #nullable disable
    
}

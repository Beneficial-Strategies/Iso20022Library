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
/// Overall holding position, in a single financial instrument, held in a securities account at a specified place of safekeeping.
/// </summary>
[IsoId("_YlFnMVV3Eea1MPROA61PoQ")]
[DisplayName("Aggregate Holding Balance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AggregateHoldingBalance3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Report on the net position of a financial instrument on the sub-account, for a certain date.
    /// </summary>
    [IsoId("_g8YpUlV3Eea1MPROA61PoQ")]
    [DisplayName("Balance For Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalForAcct")]
    #endif
    [IsoXmlTag("BalForAcct")]
    public ValueList<AggregateHoldingBalance1> BalanceForAccount { get; init; } = new ValueList<AggregateHoldingBalance1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _g8YpUlV3Eea1MPROA61PoQ
    
    /// <summary>
    /// Agent of the financial instrument, for example, a trade intermediary.
    /// </summary>
    [IsoId("_g8YpU1V3Eea1MPROA61PoQ")]
    [DisplayName("Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Agt")]
    #endif
    [IsoXmlTag("Agt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Intermediary29? Agent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Intermediary29? Agent { get; init; } 
    #else
    public Intermediary29? Agent { get; set; } 
    #endif
    
    
    #nullable disable
    
}

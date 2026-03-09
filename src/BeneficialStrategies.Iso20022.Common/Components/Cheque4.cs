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
/// Set of characteristics related to a cheque instruction, such as cheque type or cheque number.
/// </summary>
[IsoId("_QbdK-dp-Ed-ak6NoX_4Aeg_2112357361")]
[DisplayName("Cheque")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Cheque4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Cheque4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Cheque4( NameAndAddress5 reqPayeeIdentification )
    {
        PayeeIdentification = reqPayeeIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party to which a cheque is made payable.
    /// </summary>
    [IsoId("_QbdK-tp-Ed-ak6NoX_4Aeg_-2038541815")]
    [DisplayName("Payee Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PyeeId")]
    #endif
    [IsoXmlTag("PyeeId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NameAndAddress5 PayeeIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NameAndAddress5 PayeeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NameAndAddress5 PayeeIdentification { get; init; } 
    #else
    public NameAndAddress5 PayeeIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}

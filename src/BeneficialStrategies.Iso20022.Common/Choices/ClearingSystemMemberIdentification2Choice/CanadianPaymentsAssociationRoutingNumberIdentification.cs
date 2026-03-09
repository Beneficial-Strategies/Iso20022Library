// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification2Choice
{
    /// <summary>
    /// Canadian Payments Association Routing Number - identifies Canadian financial institutions on the Canadian national clearing system.
    /// </summary>
    [IsoId("_TDF7kNp-Ed-ak6NoX_4Aeg_1989940341")]
    [DisplayName("Canadian Payments Association Routing Number Identification")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record CanadianPaymentsAssociationRoutingNumberIdentification : ClearingSystemMemberIdentification2Choice_
    #else
    public partial class CanadianPaymentsAssociationRoutingNumberIdentification : ClearingSystemMemberIdentification2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a CanadianPaymentsAssociationRoutingNumberIdentification instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public CanadianPaymentsAssociationRoutingNumberIdentification( System.String reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Canadian Payments Association Routing Number. Identifies Canadian financial institutions on the Canadian national clearing system.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CACPA")]
        #endif
        [IsoXmlTag("CACPA")]
        [IsoSimpleType(IsoSimpleType.CanadianPaymentsARNIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoCanadianPaymentsARNIdentifier Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Value { get; init; } 
        #else
        public System.String Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}

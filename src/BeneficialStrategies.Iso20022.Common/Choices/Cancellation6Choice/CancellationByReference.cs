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
namespace BeneficialStrategies.Iso20022.Choices.Cancellation6Choice
{
    /// <summary>
    /// Reference of the transfer instruction to be cancelled.
    /// </summary>
    [IsoId("_r0ZQUxwnEeOIveEnnb_1-A")]
    [DisplayName("Cancellation By Reference")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record CancellationByReference : Cancellation6Choice_
    #else
    public partial class CancellationByReference : Cancellation6Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
        /// </summary>
        [IsoId("_HzyxIS8FEeO59oUFO5eLvw")]
        [DisplayName("Master Reference")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MstrRef")]
        #endif
        [IsoXmlTag("MstrRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? MasterReference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? MasterReference { get; init; } 
        #else
        public System.String? MasterReference { get; set; } 
        #endif
        
        /// <summary>
        /// Transfer and cancellation reference.
        /// </summary>
        [IsoId("_HzyxIy8FEeO59oUFO5eLvw")]
        [DisplayName("Transfer References")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TrfRefs")]
        #endif
        [IsoXmlTag("TrfRefs")]
        public ValueList<TransferReference8> TransferReferences { get; init; } = new ValueList<TransferReference8>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _HzyxIy8FEeO59oUFO5eLvw
        
        
        #nullable disable
        
    }
}

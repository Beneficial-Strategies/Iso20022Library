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
namespace BeneficialStrategies.Iso20022.Choices.Cancellation3Choice
{
    /// <summary>
    /// Reference of the transfer instruction to be cancelled.
    /// </summary>
    [IsoId("_MsHJkCcaEeK33eWt3gq4Fg")]
    [DisplayName("Cancellation By Reference")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record CancellationByReference : Cancellation3Choice_
    #else
    public partial class CancellationByReference : Cancellation3Choice_
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
        [IsoId("_Sww1cNp-Ed-ak6NoX_4Aeg_716567294")]
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
        [IsoId("_Sww1cdp-Ed-ak6NoX_4Aeg_-1130016572")]
        [DisplayName("Transfer References")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TrfRefs")]
        #endif
        [IsoXmlTag("TrfRefs")]
        public ValueList<TransferReference4> TransferReferences { get; init; } = new ValueList<TransferReference4>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _Sww1cdp-Ed-ak6NoX_4Aeg_-1130016572
        
        
        #nullable disable
        
    }
}

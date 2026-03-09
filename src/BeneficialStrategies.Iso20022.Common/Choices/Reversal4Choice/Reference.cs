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
namespace BeneficialStrategies.Iso20022.Choices.Reversal4Choice
{
    /// <summary>
    /// Reference of the transfer confirmation to be reversed.
    /// </summary>
    [IsoId("_QND7sRX3EeOBE-jZfcm4KQ")]
    [DisplayName("Reference")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Reference : Reversal4Choice_
    #else
    public partial class Reference : Reversal4Choice_
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
        [IsoId("_IeJPUy79EeO59oUFO5eLvw")]
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
        /// Unique and unambiguous identifier for a transfer instruction, as assigned by the instructing party.
        /// </summary>
        [IsoId("_IeJPVS79EeO59oUFO5eLvw")]
        [DisplayName("Transfer Reference")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TrfRef")]
        #endif
        [IsoXmlTag("TrfRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? TransferReference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? TransferReference { get; init; } 
        #else
        public System.String? TransferReference { get; set; } 
        #endif
        
        /// <summary>
        /// Unique and unambiguous investor&apos;s identification of a transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
        /// </summary>
        [IsoId("_IeJPVy79EeO59oUFO5eLvw")]
        [DisplayName("Client Reference")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ClntRef")]
        #endif
        [IsoXmlTag("ClntRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? ClientReference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ClientReference { get; init; } 
        #else
        public System.String? ClientReference { get; set; } 
        #endif
        
        /// <summary>
        /// Unique and unambiguous identifier for a transfer execution, as assigned by a confirming party.
        /// </summary>
        [IsoId("_IeJPWS79EeO59oUFO5eLvw")]
        [DisplayName("Transfer Confirmation Reference")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TrfConfRef")]
        #endif
        [IsoXmlTag("TrfConfRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? TransferConfirmationReference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? TransferConfirmationReference { get; init; } 
        #else
        public System.String? TransferConfirmationReference { get; set; } 
        #endif
        
        /// <summary>
        /// Unambiguous identification of the transfer allocated by the counterparty.
        /// </summary>
        [IsoId("_KhqmQS79EeO59oUFO5eLvw")]
        [DisplayName("Counterparty Reference")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CtrPtyRef")]
        #endif
        [IsoXmlTag("CtrPtyRef")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AdditionalReference2? CounterpartyReference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AdditionalReference2? CounterpartyReference { get; init; } 
        #else
        public AdditionalReference2? CounterpartyReference { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}

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
namespace BeneficialStrategies.Iso20022.Choices.Cancellation2Choice
{
    /// <summary>
    /// Reference of the transfer to be cancelled.
    /// </summary>
    [IsoId("_OFsU1Rg2EeK-_89we2b-bA")]
    [DisplayName("Reference")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Reference : Cancellation2Choice_
    #else
    public partial class Reference : Cancellation2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Reference instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Reference( System.String reqTransferReference )
        {
            TransferReference = reqTransferReference;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
        /// </summary>
        [IsoId("_SwUJgNp-Ed-ak6NoX_4Aeg_-1571572721")]
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
        [IsoId("_SwUJgdp-Ed-ak6NoX_4Aeg_-838136033")]
        [DisplayName("Transfer Reference")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TrfRef")]
        #endif
        [IsoXmlTag("TrfRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text TransferReference { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String TransferReference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String TransferReference { get; init; } 
        #else
        public System.String TransferReference { get; set; } 
        #endif
        
        /// <summary>
        /// Unique and unambiguous investor&apos;s identification of a transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
        /// </summary>
        [IsoId("_SwUJgtp-Ed-ak6NoX_4Aeg_-838136016")]
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
        /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
        /// </summary>
        [IsoId("_SwUJg9p-Ed-ak6NoX_4Aeg_-838135973")]
        [DisplayName("Cancellation Reference")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CxlRef")]
        #endif
        [IsoXmlTag("CxlRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? CancellationReference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? CancellationReference { get; init; } 
        #else
        public System.String? CancellationReference { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}

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
namespace BeneficialStrategies.Iso20022.Choices.PartyOrCurrency1Choice
{
    /// <summary>
    /// First party in the settlement chain. In a plain vanilla settlement, it is the Central Securities Depository where the counterparty requests to receive the financial instrument or from where the counterparty delivers the financial instruments.
    /// </summary>
    [IsoId("_o-ev0lhDEeOMYfRGLS0NbA")]
    [DisplayName("Depository")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Depository : PartyOrCurrency1Choice_
    #else
    public partial class Depository : PartyOrCurrency1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Depository instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Depository( PartyIdentification75Choice_ reqPartyIdentification )
        {
            PartyIdentification = reqPartyIdentification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identification of the party.
        /// </summary>
        [IsoId("_HUH4QUiQEeOdL6nMHefDgg")]
        [DisplayName("Party Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PtyId")]
        #endif
        [IsoXmlTag("PtyId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PartyIdentification75Choice_ PartyIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PartyIdentification75Choice_ PartyIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification75Choice_ PartyIdentification { get; init; } 
        #else
        public PartyIdentification75Choice_ PartyIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Unambiguous identification of the transaction for the party identified.
        /// </summary>
        [IsoId("_HUH4RUiQEeOdL6nMHefDgg")]
        [DisplayName("Processing Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrcgId")]
        #endif
        [IsoXmlTag("PrcgId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? ProcessingIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ProcessingIdentification { get; init; } 
        #else
        public System.String? ProcessingIdentification { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}

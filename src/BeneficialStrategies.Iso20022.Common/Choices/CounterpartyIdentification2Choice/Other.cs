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
namespace BeneficialStrategies.Iso20022.Choices.CounterpartyIdentification2Choice
{
    /// <summary>
    /// Other identification of the counterparty through the sector and the location.
    /// </summary>
    [IsoId("_Qveap3vSEeWrWYBng3OpVw")]
    [DisplayName("Other")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Other : CounterpartyIdentification2Choice_
    #else
    public partial class Other : CounterpartyIdentification2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Other instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Other( NameOrSector1Choice_ reqNameOrSector,string reqLocation )
        {
            NameOrSector = reqNameOrSector;
            Location = reqLocation;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Name or sector of the counterparty of the reporting agent used by the reporting agent.
        /// </summary>
        [IsoId("_ZqzG0YIoEeWA9fc11zJf1Q")]
        [DisplayName("Name Or Sector")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NmOrSctr")]
        #endif
        [IsoXmlTag("NmOrSctr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required NameOrSector1Choice_ NameOrSector { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required NameOrSector1Choice_ NameOrSector { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public NameOrSector1Choice_ NameOrSector { get; init; } 
        #else
        public NameOrSector1Choice_ NameOrSector { get; set; } 
        #endif
        
        /// <summary>
        /// Location of the country in which the counterparty is incorporated.
        /// </summary>
        [IsoId("_wDEl04InEeWA9fc11zJf1Q")]
        [DisplayName("Location")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Lctn")]
        #endif
        [IsoXmlTag("Lctn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CountryCode Location { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required string Location { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string Location { get; init; } 
        #else
        public string Location { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}

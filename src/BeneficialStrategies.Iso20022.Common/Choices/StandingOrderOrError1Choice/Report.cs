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
namespace BeneficialStrategies.Iso20022.Choices.StandingOrderOrError1Choice
{
    /// <summary>
    /// Reports either on the standing order or on a business error.
    /// </summary>
    [IsoId("_76G8cKMgEeCJ6YNENx4h-w_-327808063")]
    [DisplayName("Report")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Report : StandingOrderOrError1Choice_
    #else
    public partial class Report : StandingOrderOrError1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Report instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Report( StandingOrderIdentification2 reqStandingOrderIdentification,StandingOrderOrError2Choice_ reqStandingOrderOrError )
        {
            StandingOrderIdentification = reqStandingOrderIdentification;
            StandingOrderOrError = reqStandingOrderOrError;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification for the account between the account owner and the account servicer.
        /// </summary>
        [IsoId("_7-lMyKMgEeCJ6YNENx4h-w_62369976")]
        [DisplayName("Standing Order Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="StgOrdrId")]
        #endif
        [IsoXmlTag("StgOrdrId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required StandingOrderIdentification2 StandingOrderIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required StandingOrderIdentification2 StandingOrderIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public StandingOrderIdentification2 StandingOrderIdentification { get; init; } 
        #else
        public StandingOrderIdentification2 StandingOrderIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Requested information on the standing order or business error when information has not been found.
        /// </summary>
        [IsoId("_7-uWsKMgEeCJ6YNENx4h-w_2079274139")]
        [DisplayName("Standing Order Or Error")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="StgOrdrOrErr")]
        #endif
        [IsoXmlTag("StgOrdrOrErr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required StandingOrderOrError2Choice_ StandingOrderOrError { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required StandingOrderOrError2Choice_ StandingOrderOrError { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public StandingOrderOrError2Choice_ StandingOrderOrError { get; init; } 
        #else
        public StandingOrderOrError2Choice_ StandingOrderOrError { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}

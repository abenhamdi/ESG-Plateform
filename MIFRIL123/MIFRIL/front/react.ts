import React from "react";
import { VictoryBar, VictoryChart, VictoryAxis, VictoryPie, VictoryLine, VictoryArea, VictoryAnimation, VictoryLabel } from "victory";




// Données pour les graphiques
const energyConsumptionData = [
  { source: "Solaire", consumption: 30 },
  { source: "Éolienne", consumption: 45 },
  { source: "Fossile", consumption: 25 },
  { source: "Hydro", consumption: 20 }
];

const renewableGrowthData = [
  { year: 2015, usage: 20 },
  { year: 2016, usage: 25 },
  { year: 2017, usage: 30 },
  { year: 2018, usage: 40 },
  { year: 2019, usage: 50 }
];

const investmentData = [
  { project: "Solaire", investment: 50 },
  { project: "Éolienne", investment: 30 },
  { project: "Hydro", investment: 20 }
];

const emissionReductionData = [
  { year: 2015, emissions: 80 },
  { year: 2016, emissions: 70 },
  { year: 2017, emissions: 60 },
  { year: 2018, emissions: 50 },
  { year: 2019, emissions: 40 }
];

const Home1templateTwoPage: React.FC = () => {
  return (
    <div className="bg-gray-900_02 flex flex-col items-center justify-start mx-auto p-10 sm:px-5 w-full">
      {/* Header Section, Additional Content */}
      {/* ... */}
      
      {/* Charts Section */}
      <div className="flex flex-wrap justify-around w-full">
        {/* Bar Chart - Energy Consumption */}
        <div className="w-full md:w-1/2 lg:w-1/4 p-4">
          <VictoryChart domainPadding={20} animate={{duration: 400}}>
          <VictoryAxis style={customStyles.axisStyle} />
            <VictoryBar data={energyConsumptionData} x="source" y="consumption" />
          </VictoryChart>
        </div>

        {/* Line Chart - Growth of Renewable Energy Use */}
        <div className="w-full md:w-1/2 lg:w-1/4 p-4">
          <VictoryChart>
            <VictoryLine data={renewableGrowthData} x="year" y="usage" />
          </VictoryChart>
        </div>

        {/* Pie Chart - Investment in Renewable Projects */}
        <div className="w-full md:w-1/2 lg:w-1/4 p-4">
          <VictoryPie data={investmentData} x="project" y="investment" />
        </div>

        {/* Area Chart - Reduction in Emissions */}
        <div className="w-full md:w-1/2 lg:w-1/4 p-4">
          <VictoryChart>
            <VictoryArea data={emissionReductionData} x="year" y="emissions" />
          </VictoryChart>
        </div>
          <div className="bg-gray-900_02 flex flex-col items-center justify-start mx-auto p-10 sm:px-5 w-full">
            {/* Header, Button and Text Sections, Info Panels */}
            {/* ... */}
            {/* Additional Content */}
            <div className="w-full p-4">
              <h2 className="text-white text-2xl font-bold mb-4">Additional Information</h2>
              <p className="text-white text-lg">
                Here you can add any additional information or data that might be relevant to your users. 
                This can include textual descriptions, links to resources, or even additional charts and graphs. 
                Remember to keep the content relevant and easy to understand.
              </p>
              {/* Further content can go here */}
            </div>

            {/* Footer or other sections */}
            {/* ... */}
          </div>
        </div>
    </div>
)};
   export default Home1templateTwoPage;
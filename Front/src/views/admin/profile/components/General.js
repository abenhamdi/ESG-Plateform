import React, { useState, useEffect } from "react";
import axios from "axios";
import { useHistory } from "react-router-dom";
import { SimpleGrid, Text } from "@chakra-ui/react";
import Card from "components/card/Card.js";
import Information from "views/admin/profile/components/Information";

export default function GeneralInformation(props) {
  const { ...rest } = props;
  const history = useHistory();
  const [cardShadow, setCardShadow] = useState({});
  const [errorMessage, setErrorMessage] = useState("");

  const EsgmetricIds = ['1', '2', '3', '4', '5', '6'];

  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      const res = await axios.get('https://api.mifril.com/api/Mifril/{ID}');
      if (res.data.length === 0) {
        setErrorMessage("ID not found");
      } else {
        history.push('/admin/dashboard');
      }
    } catch (error) {
      console.error("Error:", error);
    }
  };
  setInterval(console.log('cardShadow', cardShadow), 100000);
  useEffect(() => {
    const fetchCardShadows = async () => {
      const shadowData = {};

      for (const EsgmetricId of EsgmetricIds) {
        try {
          const response = await axios.get(
            `${process.env.REACT_APP_BACKEND}api/Mifril/${EsgmetricId}`
          );
          const data = response.data;
          shadowData[EsgmetricId] = { sector_activity: data.sector_activity, code: data.code };
        } catch (error) {
          console.error(`Error fetching card shadow for ${EsgmetricId}:`, error);
        }
      }
      setCardShadow(shadowData);
    };

    fetchCardShadows();
  }, [EsgmetricIds]);

  return (
    <Card mb={{ base: "0px", "2xl": "20px" }} {...rest}>
      <form onSubmit={handleSubmit}>
        <button type="submit">Submit</button>
      </form>
      <Text fontWeight='bold' fontSize='2xl' mt='10px' mb='4px'>
        Badge progress
      </Text>
      <Text fontSize='md' me='26px' mb='40px'>
        Win, earn, and share your MIFRIL path to help get a better planet 
      </Text>
      <SimpleGrid columns='2' gap='20px'>
        {EsgmetricIds.map(ID => (
          <Information
            key={ID}
            boxShadow={cardShadow[ID] || "defaultShadowValue"}
            title={cardShadow[ID]?.sector_activity || "Default Title"}
            value={cardShadow[ID]?.code || "Default Code"}
          />
        ))}
      </SimpleGrid>
    </Card>
  );
}

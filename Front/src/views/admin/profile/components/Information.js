// Chakra imports
import { Box, Text, useColorModeValue, Icon } from "@chakra-ui/react";
// Custom components
import Card from "components/card/Card.js";
import React from "react";
import IconBox from "components/icons/IconBox";
import {
  MdAddTask,
  MdCloud,
  MdBarChart,
  MdFileCopy,
} from "react-icons/md";

export default function Information(props) {
  const { title, value, ...rest } = props;
  // Chakra Color Mode
  const textColorPrimary = useColorModeValue("secondaryGray.900", "white");
  const textColorSecondary = "gray.400";
  const bg = useColorModeValue("white", "navy.700");
  return (
    <Card bg={bg} {...rest}>
      <Box>
        <Text fontWeight='500' color={textColorSecondary} fontSize='sm'>
          {title}
        </Text>
        <Text color={textColorPrimary} fontWeight='500' fontSize='md'>
          {value}
        </Text>
        <IconBox
              w='28px'
              h='28px'
              bg='linear-gradient(90deg, #4481EB 0%, #04BEFE 100%)'
              icon={<Icon w='14px' h='14px' as={MdAddTask} color='white' />}
            />
      </Box>
    </Card>
  );
}

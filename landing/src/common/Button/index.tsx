import React from "react";
import { Button1, Btn, /*Button3*/ } from "./styles";
import { ButtonProps } from "../types";

export const Button = ({
  color,
  fixedWidth,
  children,
  onClick,
}: ButtonProps) => (
  <Button1 color={color} onClick={onClick}>
    <span className="actual-text"></span>
    {/* Uncomment the line below if you want the hover text to be present initially */}
    <span aria-hidden="true" className="hover-text">
      {children}
    </span>
  </Button1>
);

export const CustomBtn = ({
  color,
  fixedWidth,
  children,
  onClick,
}: ButtonProps) => (
  <Btn color={color} onClick={onClick}>
    <span className="actual-text"></span>
    {/* Uncomment the line below if you want the hover text to be present initially */}
    {children}
  </Btn>
);
/*
export const ButtonThree = ({
  color,
  fixedWidth,
  children,
  onClick,
}: ButtonProps) => (
  <Button3 color={color} onClick={onClick}>
    {/* ... your Button3 content ... }
  </Button3>
);*/
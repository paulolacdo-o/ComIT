algorithm CalculateFinalTotal
  var Number: amtPurchase, amtFinal
  
  print("Enter amount of purchase: ")
  read(amtPurchase)
  
  amtFinal <- amtPurchase - AmountSaved(amtPurchase)
  
  print("Final total is " + amtFinal + " dollars.")
end algorithm

algorithm AmountSaved(Number: amount) : Number
  var Number: discount
  
  if amount <= 1000 then
    discount <- amount * 0.3
  else
    discount <- amount * 0.35
  end if
  
  if discount > 500 then
    discount <- 500
  end if

  return discount
end algorithm

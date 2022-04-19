
module InstanceModule
  def square
    self ** 2
  end
end

module ClassModule
  def sample(n)
    if n < 0
      raise StandardError.new "Can't be negative!"
    end
    array = Array.new()
    for i in (1..n)
      array.push(rand(20))
    end
    return array
  end

  alias_method "random", "sample"
end

class Integer

  include InstanceModule

  extend ClassModule
  
  def factorial
    if self < 0 
      raise StandardError.new "Can't be negative!"
    end
    (1..self).inject(:*) || 1
  end
end


puts Integer.random(5)
